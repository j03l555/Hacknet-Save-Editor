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
            this.adminKnownFlag = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.currentComputerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.computerListBox = new System.Windows.Forms.ListBox();
            this.loadSaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.bInfoPage.SuspendLayout();
            this.listComputers.SuspendLayout();
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
            // adminKnownFlag
            // 
            this.adminKnownFlag.AutoSize = true;
            this.adminKnownFlag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminKnownFlag.Location = new System.Drawing.Point(180, 30);
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
            this.button2.Text = "Save Edits";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // currentComputerName
            // 
            this.currentComputerName.Location = new System.Drawing.Point(272, 4);
            this.currentComputerName.Name = "currentComputerName";
            this.currentComputerName.Size = new System.Drawing.Size(100, 20);
            this.currentComputerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 7);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 372);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadSaveButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.bInfoPage.ResumeLayout(false);
            this.bInfoPage.PerformLayout();
            this.listComputers.ResumeLayout(false);
            this.listComputers.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

