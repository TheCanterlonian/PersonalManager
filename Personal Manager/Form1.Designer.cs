namespace Personal_Manager
{
     ///this is the form design, not the associated actions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relativeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListOfPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToNewLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 447);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(165, 23);
            this.button12.TabIndex = 6;
            this.button12.Text = "Show and Edit Person";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(9, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 303);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Sort by Last Name";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Sort by First Name";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(140, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 20);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(195, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 476);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Individual Properties";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(112, 447);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(119, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "Delete Person";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 447);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Save Person";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 110);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 331);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 20);
            this.textBox3.TabIndex = 2;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 2;
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
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(438, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 476);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(427, 10);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 23);
            this.button13.TabIndex = 6;
            this.button13.Text = "Go";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(351, 36);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 23);
            this.button10.TabIndex = 5;
            this.button10.Text = "All Files";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(210, 36);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "Relevant Files";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(125, 36);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Go Up";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "New Folder";
            this.button7.UseVisualStyleBackColor = true;
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
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            this.relativeFilesToolStripMenuItem.Click += new System.EventHandler(this.relativeFilesToolStripMenuItem_Click);
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
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // Form1
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
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshListOfPeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ToolStripMenuItem goToNewLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
    }
}

