namespace HackNet_SaveEditor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bInfoPage = new System.Windows.Forms.TabPage();
            this.goalInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.missionInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hideMailFlag = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listComputers = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.uncrackableFlag = new System.Windows.Forms.CheckBox();
            this.portsToCrackInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.securityInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.computerPassInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminKnownFlag = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.currentComputerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.computerListBox = new System.Windows.Forms.ListBox();
            this.loadSaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.openPortsList = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.bInfoPage.SuspendLayout();
            this.listComputers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portsToCrackInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bInfoPage);
            this.tabControl1.Controls.Add(this.listComputers);
            this.tabControl1.Location = new System.Drawing.Point(1, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // bInfoPage
            // 
            this.bInfoPage.Controls.Add(this.goalInput);
            this.bInfoPage.Controls.Add(this.label5);
            this.bInfoPage.Controls.Add(this.missionInput);
            this.bInfoPage.Controls.Add(this.label4);
            this.bInfoPage.Controls.Add(this.hideMailFlag);
            this.bInfoPage.Controls.Add(this.textBox1);
            this.bInfoPage.Controls.Add(this.label2);
            this.bInfoPage.Controls.Add(this.userNameInput);
            this.bInfoPage.Controls.Add(this.label1);
            this.bInfoPage.Location = new System.Drawing.Point(4, 22);
            this.bInfoPage.Name = "bInfoPage";
            this.bInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.bInfoPage.Size = new System.Drawing.Size(627, 260);
            this.bInfoPage.TabIndex = 0;
            this.bInfoPage.Text = "Basic Info";
            this.bInfoPage.UseVisualStyleBackColor = true;
            // 
            // goalInput
            // 
            this.goalInput.Location = new System.Drawing.Point(381, 231);
            this.goalInput.Name = "goalInput";
            this.goalInput.Size = new System.Drawing.Size(222, 20);
            this.goalInput.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Current Mission:";
            // 
            // missionInput
            // 
            this.missionInput.Location = new System.Drawing.Point(79, 231);
            this.missionInput.Name = "missionInput";
            this.missionInput.Size = new System.Drawing.Size(208, 20);
            this.missionInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Next Mission:";
            // 
            // hideMailFlag
            // 
            this.hideMailFlag.AutoSize = true;
            this.hideMailFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hideMailFlag.Location = new System.Drawing.Point(3, 52);
            this.hideMailFlag.Name = "hideMailFlag";
            this.hideMailFlag.Size = new System.Drawing.Size(100, 17);
            this.hideMailFlag.TabIndex = 4;
            this.hideMailFlag.Text = "Hide Mail Icon?";
            this.hideMailFlag.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Language:";
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(67, 3);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 20);
            this.userNameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // listComputers
            // 
            this.listComputers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listComputers.Controls.Add(this.openPortsList);
            this.listComputers.Controls.Add(this.label9);
            this.listComputers.Controls.Add(this.uncrackableFlag);
            this.listComputers.Controls.Add(this.portsToCrackInput);
            this.listComputers.Controls.Add(this.label8);
            this.listComputers.Controls.Add(this.securityInput);
            this.listComputers.Controls.Add(this.label7);
            this.listComputers.Controls.Add(this.panel1);
            this.listComputers.Controls.Add(this.adminKnownFlag);
            this.listComputers.Controls.Add(this.button2);
            this.listComputers.Controls.Add(this.currentComputerName);
            this.listComputers.Controls.Add(this.label3);
            this.listComputers.Controls.Add(this.computerListBox);
            this.listComputers.Location = new System.Drawing.Point(4, 22);
            this.listComputers.Name = "listComputers";
            this.listComputers.Padding = new System.Windows.Forms.Padding(3);
            this.listComputers.Size = new System.Drawing.Size(627, 260);
            this.listComputers.TabIndex = 1;
            this.listComputers.Text = "Computers";
            this.listComputers.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ports:";
            // 
            // uncrackableFlag
            // 
            this.uncrackableFlag.AutoSize = true;
            this.uncrackableFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uncrackableFlag.Location = new System.Drawing.Point(186, 108);
            this.uncrackableFlag.Name = "uncrackableFlag";
            this.uncrackableFlag.Size = new System.Drawing.Size(93, 17);
            this.uncrackableFlag.TabIndex = 13;
            this.uncrackableFlag.Text = "Uncrackable?";
            this.uncrackableFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uncrackableFlag.UseVisualStyleBackColor = true;
            this.uncrackableFlag.CheckedChanged += new System.EventHandler(this.uncrackableFlag_CheckedChanged);
            // 
            // portsToCrackInput
            // 
            this.portsToCrackInput.Location = new System.Drawing.Point(266, 82);
            this.portsToCrackInput.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.portsToCrackInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.portsToCrackInput.Name = "portsToCrackInput";
            this.portsToCrackInput.Size = new System.Drawing.Size(31, 20);
            this.portsToCrackInput.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ports to Crack:";
            // 
            // securityInput
            // 
            this.securityInput.Location = new System.Drawing.Point(237, 55);
            this.securityInput.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.securityInput.Name = "securityInput";
            this.securityInput.Size = new System.Drawing.Size(28, 20);
            this.securityInput.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Security:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.userListBox);
            this.panel1.Controls.Add(this.computerPassInput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(381, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 191);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Apply Changes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(3, 6);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(65, 160);
            this.userListBox.TabIndex = 7;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // computerPassInput
            // 
            this.computerPassInput.Location = new System.Drawing.Point(128, 6);
            this.computerPassInput.Name = "computerPassInput";
            this.computerPassInput.Size = new System.Drawing.Size(97, 20);
            this.computerPassInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            // 
            // adminKnownFlag
            // 
            this.adminKnownFlag.AutoSize = true;
            this.adminKnownFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminKnownFlag.Location = new System.Drawing.Point(186, 32);
            this.adminKnownFlag.Name = "adminKnownFlag";
            this.adminKnownFlag.Size = new System.Drawing.Size(146, 17);
            this.adminKnownFlag.TabIndex = 4;
            this.adminKnownFlag.Text = "Admin Password Known?";
            this.adminKnownFlag.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apply Edits";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // currentComputerName
            // 
            this.currentComputerName.Location = new System.Drawing.Point(275, 6);
            this.currentComputerName.Name = "currentComputerName";
            this.currentComputerName.Size = new System.Drawing.Size(100, 20);
            this.currentComputerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Computer Name:";
            // 
            // computerListBox
            // 
            this.computerListBox.FormattingEnabled = true;
            this.computerListBox.Location = new System.Drawing.Point(8, 7);
            this.computerListBox.Name = "computerListBox";
            this.computerListBox.Size = new System.Drawing.Size(166, 238);
            this.computerListBox.TabIndex = 0;
            this.computerListBox.SelectedIndexChanged += new System.EventHandler(this.computerListBox_SelectedIndexChanged);
            // 
            // loadSaveButton
            // 
            this.loadSaveButton.Location = new System.Drawing.Point(5, 13);
            this.loadSaveButton.Name = "loadSaveButton";
            this.loadSaveButton.Size = new System.Drawing.Size(75, 23);
            this.loadSaveButton.TabIndex = 1;
            this.loadSaveButton.Text = "Load File";
            this.loadSaveButton.UseVisualStyleBackColor = true;
            this.loadSaveButton.Click += new System.EventHandler(this.loadSaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Debug Messages";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.aboutLabel.Location = new System.Drawing.Point(597, 350);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(35, 13);
            this.aboutLabel.TabIndex = 4;
            this.aboutLabel.Text = "About";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // openPortsList
            // 
            this.openPortsList.FormattingEnabled = true;
            this.openPortsList.Items.AddRange(new object[] {
            "211 - Transfer",
            "22 - SSH",
            "80 - HTTP WebServer",
            "25 - SMTP MailServer",
            "21 - FTP Server",
            "1433 - SQL Server",
            "104 - Medical Services",
            "6881 - BitTorrent",
            "443 - HTTPS (SSL)",
            "192 - Pacific Dedicated",
            "554 - RTSP",
            "9418 - Version Control",
            "3724 - Blizzard Updater",
            "3659 - eOS Connection Manager"});
            this.openPortsList.Location = new System.Drawing.Point(186, 144);
            this.openPortsList.Name = "openPortsList";
            this.openPortsList.Size = new System.Drawing.Size(193, 94);
            this.openPortsList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 372);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadSaveButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Hacknet Save Editor";
            this.tabControl1.ResumeLayout(false);
            this.bInfoPage.ResumeLayout(false);
            this.bInfoPage.PerformLayout();
            this.listComputers.ResumeLayout(false);
            this.listComputers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portsToCrackInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bInfoPage;
        private System.Windows.Forms.TabPage listComputers;
        private System.Windows.Forms.Button loadSaveButton;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox hideMailFlag;
        private System.Windows.Forms.ListBox computerListBox;
        private System.Windows.Forms.TextBox currentComputerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox adminKnownFlag;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox goalInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox missionInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.TextBox computerPassInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox uncrackableFlag;
        private System.Windows.Forms.NumericUpDown portsToCrackInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown securityInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox openPortsList;
    }
}

