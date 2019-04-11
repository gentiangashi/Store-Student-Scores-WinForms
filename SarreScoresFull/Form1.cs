using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SarreScoresFull
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            // Set to no text.  
            uiPasswordTextBox.Text = "";
            // The password character is an asterisk.  
            uiPasswordTextBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.  
            uiPasswordTextBox.MaxLength = 14;
        }

        //Number of Tries
        int numberOfTries = 0;
        string[] Collumns = { "Name","Test", "Basket","Destructive","Final Grade"};
        string[] Names = { "Alex", "Danny", "Dave", "Goerge", "Hannan", "Ian", "Muna" };     
        int[,] Grade = new int[3, 7];
        int[] FinalGrade = new int[7];

        //int[,] Grades = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        //Overall Mark = Class Test*0.40 + Conical Basket * 0.40 + Destructive Testing *0.20

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void uiPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLoginButton_Click(object sender, EventArgs e)
        {
            string password = "OpenSimSim";

            if(password == uiPasswordTextBox.Text)
            {
                uiLogOffButton.Enabled = true;
                uiLoginButton.Enabled = false;
                uiPasswordTextBox.Enabled = false;

                uiLogOffButton.Enabled = true;
                uiMarkEntryNameTextBox.Enabled = true;
                uiMarkEntryClassTestTextBox.Enabled = true;
                uiMarkEntryDestructiveTextBox.Enabled = true;
                uiStoreMarksButton.Enabled = true;
                uiShowMarksAZButton.Enabled = true;
                uiShowMarks100_0Button.Enabled = true;
                uiMarksDisplayTextBox.Enabled = true;
                uiMarkEntryConicalTextBox.Enabled = true;

            }
            else if (uiPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                numberOfTries++;
                if (numberOfTries >= 3)
                {
                    uiLoginButton.Enabled = false;
                    uiPasswordTextBox.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Incorrect Log in: Try again", "Login Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberOfTries++;
                if (numberOfTries >= 3)
                {
                    uiLoginButton.Enabled = false;
                    uiPasswordTextBox.Enabled = false;
                }
                uiLogOffButton.Enabled = false;
                uiMarkEntryNameTextBox.Enabled = false;
                uiMarkEntryClassTestTextBox.Enabled = false;
                uiMarkEntryDestructiveTextBox.Enabled = false;
                uiStoreMarksButton.Enabled = false;
                uiShowMarksAZButton.Enabled = false;
                uiShowMarks100_0Button.Enabled = false;
                uiMarksDisplayTextBox.Enabled = false;
                uiMarkEntryConicalTextBox.Enabled = false;
            }
        }
  
                            
        private void uiLogOffButton_Click(object sender, EventArgs e)
        {
            uiLoginButton.Enabled = true;
            uiPasswordTextBox.Enabled = true;

            uiLogOffButton.Enabled = false;
            uiMarkEntryNameTextBox.Enabled = false;
            uiMarkEntryClassTestTextBox.Enabled = false;
            uiMarkEntryDestructiveTextBox.Enabled = false;
            uiStoreMarksButton.Enabled = false;
            uiShowMarksAZButton.Enabled = false;
            uiShowMarks100_0Button.Enabled = false;
            uiMarksDisplayTextBox.Enabled = false;
            uiMarkEntryConicalTextBox.Enabled = false;

            uiPasswordTextBox.Text = "";
            uiMarkEntryNameTextBox.Text = "";
            uiMarkEntryClassTestTextBox.Text = "";
            uiMarkEntryDestructiveTextBox.Text = "";
            uiMarkEntryConicalTextBox.Text = "";
            uiMarksDisplayTextBox.Text = "";
        }

        private void uiMarkEntryNameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void uiMarkEntryClassTestTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiMarkEntryDestructiveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiStoreMarksButton_Click(object sender, EventArgs e)
        {

        }

        private void uiShowMarksAZButton_Click(object sender, EventArgs e)
        {

            string separator = "          ";
            uiMarksDisplayTextBox.Text = string.Join(separator, Collumns);
            foreach (string str in Names) uiMarksDisplayTextBox.Text += str + System.Environment.NewLine;

        }

        private void uiShowMarks100_0Button_Click(object sender, EventArgs e)
        {

        }

        private void uiMarksDisplayTextBox_TextChanged(object sender, EventArgs e)
        {            
            
        }

        private void uiMarkEntryConicalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
