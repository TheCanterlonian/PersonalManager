namespace Personal_Manager
{
     ///this is the form design, not the associated actions
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowEditPerson_Button = new System.Windows.Forms.Button();
            this.Contacts_ListBox = new System.Windows.Forms.ListBox();
            this.SortLastName_Button = new System.Windows.Forms.Button();
            this.SortFirstName_Button = new System.Windows.Forms.Button();
            this.ContactSearch_Button = new System.Windows.Forms.Button();
            this.ContactSearch_TextBox = new System.Windows.Forms.TextBox();
            this.ShowAll_Button = new System.Windows.Forms.Button();
            this.NewPerson_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SavePerson_Button = new System.Windows.Forms.Button();
            this.BioGraphy_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocationGo_Button = new System.Windows.Forms.Button();
            this.AllFiles_Button = new System.Windows.Forms.Button();
            this.RelevantFiles_Button = new System.Windows.Forms.Button();
            this.GoUp_Button = new System.Windows.Forms.Button();
            this.NewFolder_Button = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relativeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListOfPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToNewLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowEditPerson_Button);
            this.groupBox1.Controls.Add(this.Contacts_ListBox);
            this.groupBox1.Controls.Add(this.SortLastName_Button);
            this.groupBox1.Controls.Add(this.SortFirstName_Button);
            this.groupBox1.Controls.Add(this.ContactSearch_Button);
            this.groupBox1.Controls.Add(this.ContactSearch_TextBox);
            this.groupBox1.Controls.Add(this.ShowAll_Button);
            this.groupBox1.Controls.Add(this.NewPerson_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People";
            // 
            // ShowEditPerson_Button
            // 
            this.ShowEditPerson_Button.Location = new System.Drawing.Point(6, 447);
            this.ShowEditPerson_Button.Name = "ShowEditPerson_Button";
            this.ShowEditPerson_Button.Size = new System.Drawing.Size(165, 23);
            this.ShowEditPerson_Button.TabIndex = 6;
            this.ShowEditPerson_Button.Text = "Show and Edit Person";
            this.ShowEditPerson_Button.UseVisualStyleBackColor = true;
            this.ShowEditPerson_Button.Click += new System.EventHandler(this.ShowEditPerson_Button_Click);
            // 
            // Contacts_ListBox
            // 
            this.Contacts_ListBox.FormattingEnabled = true;
            this.Contacts_ListBox.HorizontalScrollbar = true;
            this.Contacts_ListBox.Location = new System.Drawing.Point(9, 134);
            this.Contacts_ListBox.Name = "Contacts_ListBox";
            this.Contacts_ListBox.Size = new System.Drawing.Size(165, 303);
            this.Contacts_ListBox.TabIndex = 1;
            this.Contacts_ListBox.SelectedIndexChanged += new System.EventHandler(this.Contacts_ListBox_SelectedIndexChanged);
            // 
            // SortLastName_Button
            // 
            this.SortLastName_Button.Location = new System.Drawing.Point(6, 103);
            this.SortLastName_Button.Name = "SortLastName_Button";
            this.SortLastName_Button.Size = new System.Drawing.Size(165, 23);
            this.SortLastName_Button.TabIndex = 1;
            this.SortLastName_Button.Text = "Sort by Last Name";
            this.SortLastName_Button.UseVisualStyleBackColor = true;
            this.SortLastName_Button.Click += new System.EventHandler(this.SortLastName_Button_Click);
            // 
            // SortFirstName_Button
            // 
            this.SortFirstName_Button.Location = new System.Drawing.Point(6, 74);
            this.SortFirstName_Button.Name = "SortFirstName_Button";
            this.SortFirstName_Button.Size = new System.Drawing.Size(165, 23);
            this.SortFirstName_Button.TabIndex = 1;
            this.SortFirstName_Button.Text = "Sort by First Name";
            this.SortFirstName_Button.UseVisualStyleBackColor = true;
            this.SortFirstName_Button.Click += new System.EventHandler(this.SortFirstName_Button_Click);
            // 
            // ContactSearch_Button
            // 
            this.ContactSearch_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContactSearch_Button.BackgroundImage")));
            this.ContactSearch_Button.Location = new System.Drawing.Point(140, 48);
            this.ContactSearch_Button.Name = "ContactSearch_Button";
            this.ContactSearch_Button.Size = new System.Drawing.Size(31, 20);
            this.ContactSearch_Button.TabIndex = 1;
            this.ContactSearch_Button.UseVisualStyleBackColor = true;
            this.ContactSearch_Button.Click += new System.EventHandler(this.ContactSearch_Button_Click);
            // 
            // ContactSearch_TextBox
            // 
            this.ContactSearch_TextBox.Location = new System.Drawing.Point(6, 48);
            this.ContactSearch_TextBox.Name = "ContactSearch_TextBox";
            this.ContactSearch_TextBox.Size = new System.Drawing.Size(128, 20);
            this.ContactSearch_TextBox.TabIndex = 1;
            this.ContactSearch_TextBox.TextChanged += new System.EventHandler(this.ContactSearch_TextBox_TextChanged);
            // 
            // ShowAll_Button
            // 
            this.ShowAll_Button.Location = new System.Drawing.Point(102, 19);
            this.ShowAll_Button.Name = "ShowAll_Button";
            this.ShowAll_Button.Size = new System.Drawing.Size(69, 23);
            this.ShowAll_Button.TabIndex = 1;
            this.ShowAll_Button.Text = "Show All";
            this.ShowAll_Button.UseVisualStyleBackColor = true;
            this.ShowAll_Button.Click += new System.EventHandler(this.ShowAll_Button_Click);
            // 
            // NewPerson_Button
            // 
            this.NewPerson_Button.Location = new System.Drawing.Point(6, 19);
            this.NewPerson_Button.Name = "NewPerson_Button";
            this.NewPerson_Button.Size = new System.Drawing.Size(90, 23);
            this.NewPerson_Button.TabIndex = 1;
            this.NewPerson_Button.Text = "New Person";
            this.NewPerson_Button.UseVisualStyleBackColor = true;
            this.NewPerson_Button.Click += new System.EventHandler(this.NewPerson_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_Button);
            this.groupBox2.Controls.Add(this.SavePerson_Button);
            this.groupBox2.Controls.Add(this.BioGraphy_RichTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LastName_TextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FirstName_TextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(195, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 476);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Individual Properties";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(112, 447);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(119, 23);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Delete Person";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // SavePerson_Button
            // 
            this.SavePerson_Button.Location = new System.Drawing.Point(6, 447);
            this.SavePerson_Button.Name = "SavePerson_Button";
            this.SavePerson_Button.Size = new System.Drawing.Size(100, 23);
            this.SavePerson_Button.TabIndex = 5;
            this.SavePerson_Button.Text = "Save Person";
            this.SavePerson_Button.UseVisualStyleBackColor = true;
            this.SavePerson_Button.Click += new System.EventHandler(this.SavePerson_Button_Click);
            // 
            // BioGraphy_RichTextBox
            // 
            this.BioGraphy_RichTextBox.Location = new System.Drawing.Point(6, 110);
            this.BioGraphy_RichTextBox.Name = "BioGraphy_RichTextBox";
            this.BioGraphy_RichTextBox.Size = new System.Drawing.Size(225, 331);
            this.BioGraphy_RichTextBox.TabIndex = 2;
            this.BioGraphy_RichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Biography:";
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(6, 71);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(225, 20);
            this.LastName_TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(6, 32);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(225, 20);
            this.FirstName_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocationGo_Button);
            this.groupBox3.Controls.Add(this.AllFiles_Button);
            this.groupBox3.Controls.Add(this.RelevantFiles_Button);
            this.groupBox3.Controls.Add(this.GoUp_Button);
            this.groupBox3.Controls.Add(this.NewFolder_Button);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(438, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 476);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files";
            // 
            // LocationGo_Button
            // 
            this.LocationGo_Button.Location = new System.Drawing.Point(427, 10);
            this.LocationGo_Button.Name = "LocationGo_Button";
            this.LocationGo_Button.Size = new System.Drawing.Size(32, 23);
            this.LocationGo_Button.TabIndex = 6;
            this.LocationGo_Button.Text = "Go";
            this.LocationGo_Button.UseVisualStyleBackColor = true;
            // 
            // AllFiles_Button
            // 
            this.AllFiles_Button.Location = new System.Drawing.Point(351, 36);
            this.AllFiles_Button.Name = "AllFiles_Button";
            this.AllFiles_Button.Size = new System.Drawing.Size(108, 23);
            this.AllFiles_Button.TabIndex = 5;
            this.AllFiles_Button.Text = "All Files";
            this.AllFiles_Button.UseVisualStyleBackColor = true;
            // 
            // RelevantFiles_Button
            // 
            this.RelevantFiles_Button.Location = new System.Drawing.Point(210, 36);
            this.RelevantFiles_Button.Name = "RelevantFiles_Button";
            this.RelevantFiles_Button.Size = new System.Drawing.Size(135, 23);
            this.RelevantFiles_Button.TabIndex = 4;
            this.RelevantFiles_Button.Text = "Relevant Files";
            this.RelevantFiles_Button.UseVisualStyleBackColor = true;
            // 
            // GoUp_Button
            // 
            this.GoUp_Button.Location = new System.Drawing.Point(125, 36);
            this.GoUp_Button.Name = "GoUp_Button";
            this.GoUp_Button.Size = new System.Drawing.Size(79, 23);
            this.GoUp_Button.TabIndex = 3;
            this.GoUp_Button.Text = "Go Up";
            this.GoUp_Button.UseVisualStyleBackColor = true;
            // 
            // NewFolder_Button
            // 
            this.NewFolder_Button.Location = new System.Drawing.Point(6, 36);
            this.NewFolder_Button.Name = "NewFolder_Button";
            this.NewFolder_Button.Size = new System.Drawing.Size(113, 23);
            this.NewFolder_Button.TabIndex = 2;
            this.NewFolder_Button.Text = "New Folder";
            this.NewFolder_Button.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(60, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(361, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPersonToolStripMenuItem,
            this.showPersonToolStripMenuItem,
            this.savePersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPersonToolStripMenuItem
            // 
            this.newPersonToolStripMenuItem.Name = "newPersonToolStripMenuItem";
            this.newPersonToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newPersonToolStripMenuItem.Text = "New Person";
            this.newPersonToolStripMenuItem.Click += new System.EventHandler(this.newPersonToolStripMenuItem_Click);
            // 
            // showPersonToolStripMenuItem
            // 
            this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showPersonToolStripMenuItem.Text = "Show and Edit Person";
            this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // savePersonToolStripMenuItem
            // 
            this.savePersonToolStripMenuItem.Name = "savePersonToolStripMenuItem";
            this.savePersonToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.savePersonToolStripMenuItem.Text = "Save Person";
            this.savePersonToolStripMenuItem.Click += new System.EventHandler(this.savePersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allFilesToolStripMenuItem,
            this.relativeFilesToolStripMenuItem,
            this.refreshListOfPeopleToolStripMenuItem,
            this.goToNewLocationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "View";
            // 
            // allFilesToolStripMenuItem
            // 
            this.allFilesToolStripMenuItem.Name = "allFilesToolStripMenuItem";
            this.allFilesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.allFilesToolStripMenuItem.Text = "All Files";
            // 
            // relativeFilesToolStripMenuItem
            // 
            this.relativeFilesToolStripMenuItem.Name = "relativeFilesToolStripMenuItem";
            this.relativeFilesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.relativeFilesToolStripMenuItem.Text = "Relevant Files";
            // 
            // refreshListOfPeopleToolStripMenuItem
            // 
            this.refreshListOfPeopleToolStripMenuItem.Name = "refreshListOfPeopleToolStripMenuItem";
            this.refreshListOfPeopleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.refreshListOfPeopleToolStripMenuItem.Text = "Refresh List of People";
            this.refreshListOfPeopleToolStripMenuItem.Click += new System.EventHandler(this.refreshListOfPeopleToolStripMenuItem_Click);
            // 
            // goToNewLocationToolStripMenuItem
            // 
            this.goToNewLocationToolStripMenuItem.Name = "goToNewLocationToolStripMenuItem";
            this.goToNewLocationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.goToNewLocationToolStripMenuItem.Text = "Go to Location";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.reportABugToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.reportABugToolStripMenuItem.Text = "Report a Bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Manager";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Contacts_ListBox;
        private System.Windows.Forms.Button SortLastName_Button;
        private System.Windows.Forms.Button SortFirstName_Button;
        private System.Windows.Forms.Button ContactSearch_Button;
        private System.Windows.Forms.TextBox ContactSearch_TextBox;
        private System.Windows.Forms.Button ShowAll_Button;
        private System.Windows.Forms.Button NewPerson_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SavePerson_Button;
        private System.Windows.Forms.RichTextBox BioGraphy_RichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relativeFilesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AllFiles_Button;
        private System.Windows.Forms.Button RelevantFiles_Button;
        private System.Windows.Forms.Button GoUp_Button;
        private System.Windows.Forms.Button NewFolder_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.Button ShowEditPerson_Button;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshListOfPeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.Button LocationGo_Button;
        private System.Windows.Forms.ToolStripMenuItem goToNewLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
    }
}

