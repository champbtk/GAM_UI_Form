using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace GAM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboAddMember.SelectedIndex = 0;
            disableAll();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Checking that their entry is in the valid format of 000-0000
            if (DFECodex(txtDfE.Text) == true)
            {
                //Reset labels and buttons
                disableAll();
                return;
            }

            //Defining the project folder filepath and saving it to a global variable
            var docPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            Program.dirName = $@"{docPath}\"+txtDfE.Text;

            //Checking if the defined project folder exists
            if (Directory.Exists(Program.dirName))
            {
                //Enabling all button and labels
                disableAll();
                btnPrint.Enabled = true;
                lblCurrent.Text = "Currently looking at: " + txtDfE.Text;
            }
            else
            {
                //Reset labels and buttons
                disableAll();
                MessageBox.Show("No existing GAM project with the DfE-Code of " + txtDfE.Text, "Invalid GAM Project");
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Changing Print Label status
            lblFileStatus.Text = "File Status: Loading File...";
            lblFileStatus.Refresh();

            //Running the Print command
            CMD("print");
        }

        private void btnSetAllActive_Click(object sender, EventArgs e)
        {
            //Changing Label status
            lblActiveStatus.Text = "Status: Processing...";
            lblActiveStatus.Refresh();
            //Running the Active command
            CMD("active");
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            //Changing Label status
            lblAddStatus.Text = "Status: Processing...";
            lblAddStatus.Refresh();
            //Running the Add command
            CMD("add");
        }

        private void comboClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting the index number of the selected item
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            //Displaying the class ID and state
            lblID.Text = "ID: " + Program.classID[selectedIndex];
            lblState.Text = "State: " + Program.classState[selectedIndex];
            Program.selectedClassroom = Program.classID[selectedIndex];
        }

        private void CMD(String cmd) //All the command functions
        {
            //Starting the Process
            Program.startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            Program.startInfo.WorkingDirectory = Program.dirName;
            Program.startInfo.FileName = "cmd.exe";

            //Print command
            if (cmd == "print")
            {
                try
                {
                    //Checking to see if file already exist, if so delete it
                    if (File.Exists(Program.dirName + "/class.csv"))
                    {
                        File.Delete(Program.dirName + "/class.csv");
                    }
                }
                //Catching excel file is open error
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Please close the excel file", "Cannot Access Excel File");
                    //File status reset
                    lblFileStatus.Text = "File Status:";
                    //Provisioned to Active reset
                    lblActiveStatus.Text = "Status:";
                    //AddMember reset
                    lblAddStatus.Text = "Status:";
                    return;
                }

                //Run the command in command prompt
                Program.startInfo.Arguments = "/C gam print courses > class.csv";
                Program.process.StartInfo = Program.startInfo;
                Program.process.Start();

                //Defining filename 
                var file = new FileInfo(Program.dirName + "/class.csv");

                //While File is not accessable because of writing process
                while (IsFileLocked(file)) { }

                //Wait for process to finish, close the process and let the user know
                Program.process.WaitForExit();
                Console.WriteLine(Program.process.ExitCode);
                Program.process.Close();
                lblFileStatus.Text = "File Status: File is ready!";

                //Reading through .csv file to export classroom ID and name
                //Defining file name
                string[] CSV_Output = File.ReadAllLines(Program.dirName + "/class.csv");

                //Clear the global list and combobox
                Program.classID.Clear();
                Program.className.Clear();
                Program.classState.Clear();
                Program.provisionedList.Clear();
                comboClassroomList.Items.Clear();             

                //Loop through each row and export only the class ID and name, storing it in a global list.
                foreach (string line in CSV_Output)
                {
                    //Ignore all invalid entries e.g. GAM update warning
                    if (line.Split(',')[0].All(char.IsDigit) && !(string.IsNullOrEmpty(line.Split(',')[0])))
                    {
                        Program.classID.Add(line.Split(',')[0]);
                        Program.className.Add(line.Split(',')[1]);
                        Program.classState.Add(line.Split(',')[5]);
                        //Getting the school's Google Domain
                        Program.schoolDomain = line.Split(',')[4].Split('@')[1];
                    }
                }

                lblSchoolDomain.Text = "@" + Program.schoolDomain;

                //Defining the combobox text and value
                comboClassroomList.DisplayMember = "Text";
                comboClassroomList.ValueMember = "Value";

                //Getting the number of classes
                int size = Program.classID.Count;

                //Looping through and putting all the classnames into the combobox
                for (int i = 0; i < size; i++)
                {
                    comboClassroomList.Items.Add(new { Text = Program.className[i], Value = Program.className[i] });

                    if (Program.classState[i] == "PROVISIONED")
                    {
                        Program.provisionedList.Add(Program.classID[i]);
                    }
                }

                //Setting initial value in comboClassroomList
                comboClassroomList.SelectedIndex = 0;
                lblID.Text = "ID: " + Program.classID[0];
                Console.WriteLine(Program.classID[0]);
                lblID.Refresh();
                lblState.Text = "State: " + Program.classState[0];
                lblState.Refresh();

                //Enabling buttons
                comboClassroomList.Enabled = true;
                btnAddMember.Enabled = true;
                comboAddMember.Enabled = true;
                btnSetAllActive.Enabled = true;
                //Provisioned to Active reset
                lblActiveStatus.Text = "Status:";
                //AddMember reset
                lblAddStatus.Text = "Status:";
            }

            //Active command
            if (cmd == "active")
            {
                int size = Program.provisionedList.Count;

                if (size != 0)
                {
                    for (int i = 0; i < size; i++)
                    {
                        //Run the command in command prompt
                        if (i == 0)
                        {
                            Program.allProvisionedClasses = "/C gam update course " + Program.provisionedList[i] + " state archived";
                        }
                        else
                        {
                            Program.allProvisionedClasses += " & gam update course " + Program.provisionedList[i] + " state archived";
                        }
                    }

                    //Starting the Process and add the arguement
                    Program.startInfo.Arguments = Program.allProvisionedClasses;
                    Program.process.StartInfo = Program.startInfo;
                    Program.process.Start();

                    //Wait for process to finish, close the process and let the user know
                    Program.process.WaitForExit();
                    Program.process.Close();
                    lblActiveStatus.Text = "Status: All done!";
                }
                else
                {
                    lblActiveStatus.Text = "Status: No Provisioned Classes";
                }
            }

            if (cmd == "add")
            {
                if (String.IsNullOrEmpty(txtAddMember.Text))
                {
                    MessageBox.Show("Please enter a valid email address", "Invalid Email Address");
                    lblAddStatus.Text = "Status:";
                    return;
                }
                else
                {
                    //Starting the Process and add the arguement
                    Program.startInfo.Arguments = "/C gam course " + Program.selectedClassroom + " add " + comboAddMember.SelectedItem.ToString() + " " + txtAddMember.Text + "@" + Program.schoolDomain;
                    Program.process.StartInfo = Program.startInfo;
                    Program.process.Start();

                    //Wait for process to finish
                    Program.process.WaitForExit();

                    //Error 403, invalid email address
                    if (Program.process.ExitCode == 403)
                    {
                        MessageBox.Show("There is no user with this email address", "Invalid Email Address");
                        lblAddStatus.Text = "Status:";
                        return;
                    }
                    //Error 409, user already exist
                    if (Program.process.ExitCode == 409)
                    {
                        MessageBox.Show("This user already exist in this classroom", "User Already Exists");
                        lblAddStatus.Text = "Status:";
                        return;
                    }

                    //Close the process and let the user know
                    Program.process.Close();

                    //Changing Label status
                    lblAddStatus.Text = "Status: User added!";
                }
            }
        }

        private bool DFECodex(string s) //Function to check regex for DfE format
        {
            if (!Regex.IsMatch(s, "^[0-9]{3}-[0-9]{4}$"))
            {
                MessageBox.Show(this, "DFE code should be in 000-0000 format", "DFE Code Error");
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual bool IsFileLocked(FileInfo file) //Function to check if file is still locked
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
        private void disableAll()
        {
            //Reset labels and buttons
            btnPrint.Enabled = false;
            btnSetAllActive.Enabled = false;
            comboClassroomList.Enabled = false;
            btnAddMember.Enabled = false;
            lblCurrent.Text = "Currently looking at:";
            lblFileStatus.Text = "File Status:";
            lblID.Text = "ID:";
            lblState.Text = "State:";
            lblActiveStatus.Text = "Status:";
            lblSchoolDomain.Text = "@";
            lblAddStatus.Text = "Status:";
            comboAddMember.Enabled = false;
            comboClassroomList.Items.Clear();
        }
    }
}
