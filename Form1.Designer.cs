namespace GAM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDfE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.comboClassroomList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.btnSetAllActive = new System.Windows.Forms.Button();
            this.lblSetAllActive = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.lblSchoolDomain = new System.Windows.Forms.Label();
            this.txtAddMember = new System.Windows.Forms.TextBox();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.comboAddMember = new System.Windows.Forms.ComboBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblAddStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDfE
            // 
            this.txtDfE.Location = new System.Drawing.Point(47, 64);
            this.txtDfE.Name = "txtDfE";
            this.txtDfE.Size = new System.Drawing.Size(100, 22);
            this.txtDfE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter DfE-Code";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(153, 63);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 25);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(44, 103);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(126, 16);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "Currently looking at: ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(47, 178);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 25);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Run";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.AutoSize = true;
            this.lblFileStatus.Location = new System.Drawing.Point(44, 215);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(72, 16);
            this.lblFileStatus.TabIndex = 5;
            this.lblFileStatus.Text = "File Status:";
            // 
            // comboClassroomList
            // 
            this.comboClassroomList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClassroomList.FormattingEnabled = true;
            this.comboClassroomList.Location = new System.Drawing.Point(47, 292);
            this.comboClassroomList.Name = "comboClassroomList";
            this.comboClassroomList.Size = new System.Drawing.Size(206, 24);
            this.comboClassroomList.TabIndex = 6;
            this.comboClassroomList.SelectedIndexChanged += new System.EventHandler(this.comboClassList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Import Data from Google";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "List of classrooms";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(44, 330);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID: ";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(44, 358);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 16);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            // 
            // btnSetAllActive
            // 
            this.btnSetAllActive.Location = new System.Drawing.Point(315, 64);
            this.btnSetAllActive.Name = "btnSetAllActive";
            this.btnSetAllActive.Size = new System.Drawing.Size(100, 24);
            this.btnSetAllActive.TabIndex = 11;
            this.btnSetAllActive.Text = "Enter";
            this.btnSetAllActive.UseVisualStyleBackColor = true;
            this.btnSetAllActive.Click += new System.EventHandler(this.btnSetAllActive_Click);
            // 
            // lblSetAllActive
            // 
            this.lblSetAllActive.AutoSize = true;
            this.lblSetAllActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetAllActive.Location = new System.Drawing.Point(312, 36);
            this.lblSetAllActive.Name = "lblSetAllActive";
            this.lblSetAllActive.Size = new System.Drawing.Size(230, 16);
            this.lblSetAllActive.TabIndex = 12;
            this.lblSetAllActive.Text = "Set all \"Provisioned\" as \"Active\"";
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.Location = new System.Drawing.Point(312, 103);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(47, 16);
            this.lblActiveStatus.TabIndex = 13;
            this.lblActiveStatus.Text = "Status:";
            // 
            // lblSchoolDomain
            // 
            this.lblSchoolDomain.AutoSize = true;
            this.lblSchoolDomain.Location = new System.Drawing.Point(421, 296);
            this.lblSchoolDomain.Name = "lblSchoolDomain";
            this.lblSchoolDomain.Size = new System.Drawing.Size(21, 16);
            this.lblSchoolDomain.TabIndex = 14;
            this.lblSchoolDomain.Text = "@";
            // 
            // txtAddMember
            // 
            this.txtAddMember.Location = new System.Drawing.Point(315, 292);
            this.txtAddMember.Name = "txtAddMember";
            this.txtAddMember.Size = new System.Drawing.Size(100, 22);
            this.txtAddMember.TabIndex = 15;
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMember.Location = new System.Drawing.Point(312, 264);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(153, 16);
            this.lblAddMember.TabIndex = 16;
            this.lblAddMember.Text = "Add member to class";
            // 
            // comboAddMember
            // 
            this.comboAddMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddMember.FormattingEnabled = true;
            this.comboAddMember.Items.AddRange(new object[] {
            "teacher",
            "student"});
            this.comboAddMember.Location = new System.Drawing.Point(315, 327);
            this.comboAddMember.Name = "comboAddMember";
            this.comboAddMember.Size = new System.Drawing.Size(100, 24);
            this.comboAddMember.TabIndex = 17;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(424, 327);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(100, 24);
            this.btnAddMember.TabIndex = 18;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lblAddStatus
            // 
            this.lblAddStatus.AutoSize = true;
            this.lblAddStatus.Location = new System.Drawing.Point(312, 368);
            this.lblAddStatus.Name = "lblAddStatus";
            this.lblAddStatus.Size = new System.Drawing.Size(47, 16);
            this.lblAddStatus.TabIndex = 19;
            this.lblAddStatus.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(687, 415);
            this.Controls.Add(this.lblAddStatus);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.comboAddMember);
            this.Controls.Add(this.lblAddMember);
            this.Controls.Add(this.txtAddMember);
            this.Controls.Add(this.lblSchoolDomain);
            this.Controls.Add(this.lblActiveStatus);
            this.Controls.Add(this.lblSetAllActive);
            this.Controls.Add(this.btnSetAllActive);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboClassroomList);
            this.Controls.Add(this.lblFileStatus);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDfE);
            this.Name = "Form1";
            this.Text = "GAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDfE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.ComboBox comboClassroomList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnSetAllActive;
        private System.Windows.Forms.Label lblSetAllActive;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.Label lblSchoolDomain;
        private System.Windows.Forms.TextBox txtAddMember;
        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.ComboBox comboAddMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblAddStatus;
    }
}

