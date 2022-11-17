using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Manager
{
    public partial class Form1 : Form
    {
        //class-wide random number generator
        public static Random _random = new Random();
        public Form1()
        {
            //initiallizes the main form
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows the about box
            Form2 hello = new Form2();
            hello.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //populate the list of people
            refreshPeopleList(sender, e);
        }
        private void refreshPeopleList(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //clear the list before repopulating it
            string[] dirs = Directory.GetDirectories(@"C:\CanterlotApplications\PersonalManager\");
            foreach (string dir in dirs)
            {
                listBox1.Items.Add(Path.GetFileName(dir));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //create a new person
            int newFolderNumberOne = _random.Next(2147483646);
            int newFolderNumberTwo = _random.Next(2147483646);
            string newFolderName = newFolderNumberOne.ToString()+" "+newFolderNumberTwo.ToString();
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
            listBox1.Items.Clear();
            textBox1.Clear();
            //clear property boxes
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            //populate the list of people
            refreshPeopleList(sender, e);
        }
        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new person
            button1_Click(sender, e);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //if nothing is selected from listBox1, don't do anything
            if (listBox1.SelectedItem != null)
            {
                //find out which person is selected
                string selectedListBoxItem = listBox1.Items[listBox1.SelectedIndex].ToString();
                //delete person
                Directory.Delete(@"C:\CanterlotApplications\PersonalManager\" + selectedListBoxItem, true);
                textBox1.Clear();
                //clear property boxes
                textBox2.Clear();
                textBox3.Clear();
                richTextBox1.Clear();
                //populate the list of people
                refreshPeopleList(sender, e);
            }
        }
        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete person
            button11_Click(sender, e);
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //clear property boxes
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            //populate the list of people
            refreshPeopleList(sender, e);
        }
        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if nothing is selected from listBox1, don't do anything
            if (listBox1.SelectedItem != null)
            {
                //create the files for the person if they don't exist already
                string selectedFolder = listBox1.SelectedItem.ToString();
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
                    textBox2.Clear();
                    string firstNameFile = File.ReadAllText(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\first.txt");
                    textBox2.Text = firstNameFile;
                }
                if (File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt"))
                {
                    textBox3.Clear();
                    string lastNameFile = File.ReadAllText(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt");
                    textBox3.Text = lastNameFile;
                }
                if (File.Exists(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt"))
                {
                    richTextBox1.Clear();
                    string bioFile = File.ReadAllText(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt");
                    richTextBox1.Text = bioFile;
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //show properties of person from the files in the boxes
            showPersonToolStripMenuItem_Click(sender, e);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPersonToolStripMenuItem_Click(sender, e);
        }

        private void refreshListOfPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //clear property boxes
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            //refresh list of people
            button2_Click(sender, e);
        }

        private void relativeFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows the bug-report box
            Form3 hello = new Form3();
            hello.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if nothing is selected from listBox1, don't do anything
            if (listBox1.SelectedItem != null)
            {
                //find out what person is being edited
                string selectedFolder = listBox1.SelectedItem.ToString();
                //write stuff in property boxes to files
                StreamWriter swFirst = new StreamWriter(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\first.txt");
                swFirst.Write(textBox2.Text);
                swFirst.Close();
                StreamWriter swLast = new StreamWriter(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\last.txt");
                swLast.Write(textBox3.Text);
                swLast.Close();
                StreamWriter swBio = new StreamWriter(@"C:\CanterlotApplications\PersonalManager\" + selectedFolder + @"\bio.txt");
                swBio.Write(richTextBox1.Text);
                swBio.Close();
                //remember to always close the streams
                string firstNameToCombine = (textBox2.Text);
                string lastNameToCombine = (textBox3.Text);
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
                button2_Click(sender, e);
                //refresh list of people after doing all of this
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void savePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save names and biography to the files
            button6_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //refreshing actually sorts by first name alphabetically by default
            button2_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //trying to sort listbox items by last name here
            textBox1.Clear();
            //clear property boxes
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            //clear the list before repopulating it
            listBox1.Items.Clear();
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
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
                foreach(string dir in FailedDIRs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
            }
            catch (Exception)
            {
                //shows the error box
                Form4 olah = new Form4();
                olah.Show();
                textBox1.Clear();
                //clear property boxes
                textBox2.Clear();
                textBox3.Clear();
                richTextBox1.Clear();
                //refresh list of people
                button2_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using text from textBox1 to search the listbox items
            //try deleting all items that don't match up
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
