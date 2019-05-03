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
        int[,] Grade = new int[7, 3];
        int[] FinalGrade = new int[7];

        string nameINPUT = "";

        string ClassTestINPUT;
        int ClassTestOUTPUT = 0;

        string ConicalBasketINPUT;
        int ConicalBasketOUTPUT = 0;

        string EntryDestructiveINPUT;
        int EntryDestructiveOUTPUT = 0;      
               
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void uiPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void uiLoginButton_Click(object sender, EventArgs e)
        {
            //string password = "OpenSimSim";
            string password = "1";

            if (password == uiPasswordTextBox.Text)
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
            nameINPUT = uiMarkEntryNameTextBox.Text;
        }

        private void uiMarkEntryClassTestTextBox_TextChanged(object sender, EventArgs e)
        {
            ClassTestINPUT = uiMarkEntryClassTestTextBox.Text;
            var isNumber = int.TryParse(ClassTestINPUT, out ClassTestOUTPUT);      
        }

        private void uiMarkEntryConicalTextBox_TextChanged(object sender, EventArgs e)
        {
            ConicalBasketINPUT = uiMarkEntryConicalTextBox.Text;
            var isNumber = int.TryParse(ConicalBasketINPUT, out ConicalBasketOUTPUT);
        }

        private void uiMarkEntryDestructiveTextBox_TextChanged(object sender, EventArgs e)
        {
            EntryDestructiveINPUT = uiMarkEntryDestructiveTextBox.Text;
            var isNumber = int.TryParse(EntryDestructiveINPUT, out EntryDestructiveOUTPUT);
        }

        private void uiStoreMarksButton_Click(object sender, EventArgs e)
        {
            if (ClassTestOUTPUT >= 1 && ClassTestOUTPUT <= 100)
            {
                //success
            }
            else if (ConicalBasketOUTPUT >= 1 && ConicalBasketOUTPUT <= 100)
            {
                //success
            }
            else if (EntryDestructiveOUTPUT >= 1 && EntryDestructiveOUTPUT <= 100)
            {
                //success
            }
            else
            {
                MessageBox.Show("Please Enter a Number Between 1 - 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClassTestOUTPUT = 0;
                ConicalBasketOUTPUT = 0;
                EntryDestructiveOUTPUT = 0;

            }

            double finalGrade = ClassTestOUTPUT * 0.40 + ConicalBasketOUTPUT * 0.40 + EntryDestructiveOUTPUT * 0.20;
            int FinalINTGrade = Convert.ToInt32(finalGrade);
            if (Names.Contains(nameINPUT))
            {
                if(nameINPUT == "Alex")
                {
                    Grade[0, 0] = ClassTestOUTPUT;
                    Grade[0, 1] = ConicalBasketOUTPUT;
                    Grade[0, 2] = EntryDestructiveOUTPUT;
                    FinalGrade[0] = FinalINTGrade;
                }
                else if(nameINPUT == "Danny")
                {
                    Grade[1, 0] = ClassTestOUTPUT;
                    Grade[1, 1] = ConicalBasketOUTPUT;
                    Grade[1, 2] = EntryDestructiveOUTPUT;
                    FinalGrade[1] = FinalINTGrade;
                }
                else if (nameINPUT == "Dave")
                {
                    Grade[2, 0] = ClassTestOUTPUT;
                    Grade[2, 1] = ConicalBasketOUTPUT;
                    Grade[2, 2] = EntryDestructiveOUTPUT;
                    FinalGrade[2] = FinalINTGrade;
                }
                else if (nameINPUT == "Goerge")
                {
                    Grade[3, 0] = ClassTestOUTPUT;
                    Grade[3, 1] = ConicalBasketOUTPUT;
                    Grade[3, 2] = EntryDestructiveOUTPUT;
                    FinalGrade[3] = FinalINTGrade;
                }
                else if (nameINPUT == "Hannan")
                {
                    Grade[4, 0] = ClassTestOUTPUT;
                    Grade[4, 1] = ConicalBasketOUTPUT;
                    Grade[4, 2] = EntryDestructiveOUTPUT;
                    FinalGrade[4] = FinalINTGrade;
                }
                else if (nameINPUT == "Ian")
                {
                    Grade[5, 0] = ClassTestOUTPUT;
                    Grade[5, 1] = ConicalBasketOUTPUT;
                    Grade[5, 2] = EntryDestructiveOUTPUT;
                    FinalGrade[5] = FinalINTGrade;
                }
                else if (nameINPUT == "Muna")
                {
                    Grade[6, 0] = ClassTestOUTPUT;
                    Grade[6, 1] = ConicalBasketOUTPUT;
                    Grade[6, 2] = EntryDestructiveOUTPUT;
                    FinalGrade[6] = FinalINTGrade;
                }
            }
            else
            {
                MessageBox.Show("Marks not stored: Name not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uiMarkEntryNameTextBox.Text = "";
            }
            uiMarkEntryNameTextBox.Text = "";
            uiMarkEntryClassTestTextBox.Text = "";
            uiMarkEntryConicalTextBox.Text = "";
            uiMarkEntryDestructiveTextBox.Text = "";
        }

        private void uiShowMarksAZButton_Click(object sender, EventArgs e)
        {         
            uiMarksDisplayTextBox.Text = string.Join("\t", Collumns);
            uiMarksDisplayTextBox.Text += System.Environment.NewLine;

            for (int i = 0; i < Names.Length; i++)
            {
                uiMarksDisplayTextBox.Text += Names[i];
                for (int x = 0; x < 3; x++)
                {
                    uiMarksDisplayTextBox.Text += "\t" + Grade[i, x];
                }
                uiMarksDisplayTextBox.Text += "\t" + "\t" + (FinalGrade[i]);
                uiMarksDisplayTextBox.Text += System.Environment.NewLine;
            }
        }

        private class Student
        {
            public string Name { get; set; }
            public int Test { get; set; }
            public int Basket { get; set; }
            public int Destructive { get; set; }
            public int FinalGrade { get; set; }
        }

        private void uiShowMarks100_0Button_Click(object sender, EventArgs e)
        {
            var input = new Student[]
            {
             new Student {Name = Names[0],    Test = Grade[0,0],   Basket = Grade[0, 1],  Destructive = Grade[0, 2],    FinalGrade = FinalGrade[0]  },
             new Student {Name = Names[1],    Test = Grade[1,0],   Basket = Grade[1, 1],  Destructive = Grade[1, 2],    FinalGrade = FinalGrade[1], },
             new Student {Name = Names[2],    Test = Grade[2,0],   Basket = Grade[2, 1],  Destructive = Grade[2, 2],    FinalGrade = FinalGrade[2], },
             new Student {Name = Names[3],    Test = Grade[3,0],   Basket = Grade[3, 1],  Destructive = Grade[3, 2],    FinalGrade = FinalGrade[3], },
             new Student {Name = Names[4],    Test = Grade[4,0],   Basket = Grade[4, 1],  Destructive = Grade[4, 2],    FinalGrade = FinalGrade[4], },
             new Student {Name = Names[5],    Test = Grade[5,0],   Basket = Grade[5, 1],  Destructive = Grade[5, 2],    FinalGrade = FinalGrade[5], },
             new Student {Name = Names[6],    Test = Grade[6,0],   Basket = Grade[6, 1],  Destructive = Grade[6, 2],    FinalGrade = FinalGrade[6], },
            };
            var sorted = input.OrderByDescending(student => student.FinalGrade).ToArray();

            //foreach (var row in input)
            //{
            //    uiMarksDisplayTextBox.Text = string.Join("\t", row.AsEnumerable());
            //}
        }



        private void uiMarksDisplayTextBox_TextChanged(object sender, EventArgs e)
        {                        
        }        
    }
}
