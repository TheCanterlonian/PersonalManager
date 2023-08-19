using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Personal_Manager
{
    public partial class Main_Form : Form
    {
        //class-wide random number generator
        public static Random _random = new Random();

        public Main_Form()
        {
            //initiallizes the main form
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows the about box
            About_Form about_form = new About_Form();
            about_form.Show();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            //populate the list of people
            refreshPeopleList(sender, e);

        }
        private void refreshPeopleList(object sender, EventArgs e)
        {
            Contacts_ListBox.Items.Clear();
            //clear the list before repopulating it
            string[] dirs = Directory.GetDirectories(@"C:\CanterlotApplications\PersonalManager\");
            foreach (string dir in dirs)
            {
                Contacts_ListBox.Items.Add(Path.GetFileName(dir));
            }
        }
        private void NewPerson_Button_Click(object sender, EventArgs e)
        {
            //create a new person
            int newFolderNumberOne = _random.Next(2147483646);
            int newFolderNumberTwo = _random.Next(2147483646);

            string newFolderName = newFolderNumberOne.ToString() + " " + newFolderNumberTwo.ToString();
            while (Directory.Exists(newFolderName))
            {
                //don't make a new folder with the same name as one that exists
                newFolderNumberOne = _random.Next(2147483646);
                newFolderNumberTwo = _random.Next(2147483646);
                newFolderName = newFolderNumberOne.ToString() + " " + newFolderNumberTwo.ToString();
            }
            Directory.CreateDirectory(@"C:\CanterlotApplications\PersonalManager\" + newFolderName);
            Directory.CreateDirectory(@"C:\CanterlotApplications\PersonalManager\" + newFolderName + @"\files");
            var newFirst = File.Create(@"C:\CanterlotApplications\PersonalManager\" + newFolderName + @"\first.txt");
            newFirst.Close();
            File.WriteAllText(@"C:\CanterlotApplications\PersonalManager\" + newFolderName + @"\first.txt", newFolderName);
            var newLast = File.Create(@"C:\CanterlotApplications\PersonalManager\" + newFolderName + @"\last.txt");
            newLast.Close();
            var newBio = File.Create(@"C:\CanterlotApplications\PersonalManager\" + newFolderName + @"\bio.txt");
            newBio.Close();
            Contacts_ListBox.Items.Clear();
            ContactSearch_TextBox.Clear();
            //clear property boxes
            FirstName_TextBox.Clear();
            LastName_TextBox.Clear();
            BioGraphy_RichTextBox.Clear();
            //populate the list of people
            refreshPeopleList(sender, e);
        }
        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new person
            NewPerson_Button_Click(sender, e);
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            //if nothing is selected from listBox1, don't do anything
            if (Contacts_ListBox.SelectedItem == null) return;

            //find out which person is selected
            string selectedListBoxItem = Contacts_ListBox.Items[Contacts_ListBox.SelectedIndex].ToString();
            //delete person
            Directory.Delete(@"C:\CanterlotApplications\PersonalManager\" + selectedListBoxItem, true);
            ContactSearch_TextBox.Clear();
            //clear property boxes
            FirstName_TextBox.Clear();
            LastName_TextBox.Clear();
            BioGraphy_RichTextBox.Clear();
            //populate the list of people
            refreshPeopleList(sender, e);

        }
        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete person
            Delete_Button_Click(sender, e);
        }
        private void ShowAll_Button_Click(object sender, EventArgs e)
        {
            ContactSearch_TextBox.Clear();
            //clear property boxes
            FirstName_TextBox.Clear();
            LastName_TextBox.Clear();
            BioGraphy_RichTextBox.Clear();
            //populate the list of people
            refreshPeopleList(sender, e);
        }
        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if nothing is selected from listBox1, don't do anything
            if (Contacts_ListBox.SelectedItem != null)
            {
                //create the files for the person if they don't exist already
                string selectedFolder = Contacts_ListBox.SelectedItem.ToString();
                if (!File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\first.txt"))
                {
                    var newFirst = File.Create(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\first.txt");
                    newFirst.Close();
                }
                if (!File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt"))
                {
                    var newLast = File.Create(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt");
                    newLast.Close();
                }
                if (!File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt"))
                {
                    var newBio = File.Create(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt");
                    newBio.Close();
                }
                //show properties of person from the files in the boxes if they do exist
                if (File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\first.txt"))
                {
                    FirstName_TextBox.Clear();
                    string firstNameFile = File.ReadAllText(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\first.txt");
                    FirstName_TextBox.Text = firstNameFile;
                }
                if (File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt"))
                {
                    LastName_TextBox.Clear();
                    string lastNameFile = File.ReadAllText(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt");
                    LastName_TextBox.Text = lastNameFile;
                }
                if (File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt"))
                {
                    BioGraphy_RichTextBox.Clear();
                    string bioFile = File.ReadAllText(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt");
                    BioGraphy_RichTextBox.Text = bioFile;
                }
            }
        }
        private void ShowEditPerson_Button_Click(object sender, EventArgs e)
        {
            //show properties of person from the files in the boxes
            showPersonToolStripMenuItem_Click(sender, e);
        }
        private void Contacts_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPersonToolStripMenuItem_Click(sender, e);
        }
        private void refreshListOfPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactSearch_TextBox.Clear();
            //clear property boxes
            FirstName_TextBox.Clear();
            LastName_TextBox.Clear();
            BioGraphy_RichTextBox.Clear();
            //refresh list of people
            ShowAll_Button_Click(sender, e);
        }
        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows the bug-report box
            BugReport_Form hello = new BugReport_Form();
            hello.Show();
        }
        private void SavePerson_Button_Click(object sender, EventArgs e)
        {
            //prevents user from puuting spaces in the names wich will mess with the sorting algorithms.
            if (FirstName_TextBox.Text.Contains(" ") || LastName_TextBox.Text.Contains(" "))
            {
                FirstName_TextBox.Text.Replace(" ", "_");
                LastName_TextBox.Text.Replace(" ", "_");
            }

            //if nothing is selected from listBox1, don't do anything
            if (Contacts_ListBox.SelectedItem == null) return;

            //find out what person is being edited
            string selectedFolder = Contacts_ListBox.SelectedItem.ToString();
            //write stuff in property boxes to files
            StreamWriter swFirst = new StreamWriter(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\first.txt");
            swFirst.Write(FirstName_TextBox.Text);
            swFirst.Close();
            StreamWriter swLast = new StreamWriter(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt");
            swLast.Write(LastName_TextBox.Text);
            swLast.Close();
            StreamWriter swBio = new StreamWriter(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt");
            swBio.Write(BioGraphy_RichTextBox.Text);
            swBio.Close();
            //remember to always close the streams
            string firstNameToCombine = (FirstName_TextBox.Text);
            string lastNameToCombine = (LastName_TextBox.Text);
            string firstTrimed = firstNameToCombine.Trim();
            string lastTrimed = lastNameToCombine.Trim();
            firstTrimed = firstTrimed.Replace(" ", "_");
            lastTrimed = lastTrimed.Replace(" ", "_");
            //get rid of other spaces in names
            string colapsedNames = firstTrimed + " " + lastTrimed;
            //combine first and last name into a single variable using spaces as terminators
            string sourceDirectory = @"C:\CanterlotApplications\PersonalManager\" + selectedFolder;
            string destinationDirectory = @"C:\CanterlotApplications\PersonalManager\" + colapsedNames;
            try
            {
                Directory.Move(sourceDirectory, destinationDirectory);
            }
            catch (Exception)
            {
                StreamWriter swException = new StreamWriter(@"C:\CanterlotApplications\PersonalManager\ErrorLog.txt", true);
                swException.WriteLine("Error: Standard input tried to give two people the same name. Tried renaming '" + sourceDirectory + "' to '" + destinationDirectory + "'. Item was '" + colapsedNames + "'.");
                swException.Close();
            }
            ShowAll_Button_Click(sender, e);
            //refresh list of people after doing all of this

        }
        private void savePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save names and biography to the files
            SavePerson_Button_Click(sender, e);
        }

        private void SortFirstName_Button_Click(object sender, EventArgs e)
        {
            //refreshing actually sorts by first name alphabetically by default
            ShowAll_Button_Click(sender, e);
        }

        private void SortLastName_Button_Click(object sender, EventArgs e)
        {
            //trying to sort listbox items by last name here
            ContactSearch_TextBox.Clear();
            //clear property boxes
            FirstName_TextBox.Clear();
            LastName_TextBox.Clear();
            BioGraphy_RichTextBox.Clear();
            //clear the list before repopulating it
            Contacts_ListBox.Items.Clear();
            //populate the list of people
            string[] dirs = Directory.GetDirectories(@"C:\CanterlotApplications\PersonalManager\");
            try
            {
                List<string> AcceptedDIRs = new List<string>();//Accepted DIRs are the ones that have both first names and lastnames
                List<string> FailedDIRs = new List<string>();
                foreach (string dir in dirs)
                {
                    if (dir.Contains(" ")) AcceptedDIRs.Add(dir);
                    else FailedDIRs.Add(dir);
                }
                //in last-name alphabetical ordering
                foreach (string dir in AcceptedDIRs.OrderBy(p => p.Split(' ')[1]))
                {
                    Contacts_ListBox.Items.Add(Path.GetFileName(dir));
                }
                foreach (string dir in FailedDIRs)
                {
                    Contacts_ListBox.Items.Add(Path.GetFileName(dir));
                }
            }
            catch (Exception)
            {
                //shows the error box
                Error_Form olah = new Error_Form();
                olah.Show();
                ContactSearch_TextBox.Clear();
                //clear property boxes
                FirstName_TextBox.Clear();
                LastName_TextBox.Clear();
                BioGraphy_RichTextBox.Clear();
                //refresh list of people
                ShowAll_Button_Click(sender, e);
            }
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContactSearch_Button_Click(object sender, EventArgs e)
        {
            //resets/clear the contacts listbox
            Contacts_ListBox.Items.Clear();

            //gets all the contact directories
            string[] Contacts = Directory.GetDirectories(@"C:\CanterlotApplications\PersonalManager\");
            //gets the string user is searching for from textbox
            string Inquiry = ContactSearch_TextBox.Text;
            //goes through all the contacts and searches for matches
            foreach(string Contact in Contacts)
            {
                if (Path.GetFileName(Contact).ToLower().Contains(Inquiry.ToLower()))
                {
                    Contacts_ListBox.Items.Add(Path.GetFileName(Contact));
                }
            }
        }

        private void ContactSearch_TextBox_TextChanged(object sender, EventArgs e)
        {
            //if contactSearch_Texbox is empty --> refresh contacts(show all contacts)
            //else ------------------------------> call ContactSearch_Button_Click to search through contacts

            if (ContactSearch_TextBox.Text == null) refreshPeopleList(sender, e);
            else
            {
                ContactSearch_Button_Click(sender, e);
            }
        }
    }
}
