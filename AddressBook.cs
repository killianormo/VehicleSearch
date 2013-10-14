using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Using IO for StreamReader
using System.IO;

namespace World_Email2
{
    public partial class frmAddressBook : Form
    {
        string names;
        string emails;

        public frmAddressBook()
        {
            InitializeComponent();
        }

        public void frmAddressBook_Load(object sender, EventArgs e)
        {
            //Populate the email address box.
            //Name the file to read.
            string filename = "addresses.csv";

            try
            {
                //Instantiate the stream reader.
                //Pass in the filename as a constructor argument.
                StreamReader sr = new StreamReader(filename);

                //Iterate through the file line by line.
                while (sr.EndOfStream.Equals(false))
                {
                    //Read the file and add to the listbox..
                    lstAddresses.Items.Add(sr.ReadLine());
                }//while

                //Close the stream reader.
                sr.Close();
            }
            catch (IOException)
            {
                //Inform the user.
                MessageBox.Show("Could not find the file " + filename);
            }
        }


        public void btnOK_Click(object sender, EventArgs e)
        {
            //Split the names and email addresses.
            //Show the names in the email and address listboxes in World Email.

            //String array to store the information.
            string[] namesEmailAddresses = new string[4];

            //Name the file to read.
            string filename = "addresses.csv";

            //String for temporary storage.
            string tmpLine;

            try
            {
                //Instantiate the stream reader.
                //Pass in the filename as the constructor argument.
                StreamReader sr = new StreamReader(filename);

                //Read to the end of the file.
                while (sr.EndOfStream.Equals(false))
                {
                    //Read the line.
                    tmpLine = sr.ReadLine();

                    if (tmpLine.StartsWith(lstAddresses.SelectedItem.ToString()))
                    {
                        //Split the line at the comma.
                        namesEmailAddresses = tmpLine.Split(',');

                        //Check

                        //Apply the results to strings.
                        this.names = namesEmailAddresses[0].ToString();
                        this.emails = namesEmailAddresses[1].ToString();

                        Email isValid = new Email(this.emails);
                        if (isValid.checkEmail(this.emails) == false)
                        {
                            MessageBox.Show("Invalid Email Address");
                            Application.Exit();
                        }

                       
                    }//if

                }//while

                

                //Close the stream reader.
                sr.Close();

            }
            catch (IOException)
            {
                MessageBox.Show("Selection Error");
            }

            this.Hide();
        }


        public void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the address book on clicking cancel.
            this.Close();
        }
       
        //Create method to get names.
        public string getName()
        {            
            return names;
        }

        public string getEmail()
        {
            return emails;
        }

      

    }
}

