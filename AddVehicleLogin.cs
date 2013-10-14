using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VehicleSearch
{
    public partial class frmAddVehicleLogin : Form
    {
        frmAddVehicle dlgAddVehicle;

        public frmAddVehicleLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Set checkbox for hiding password characters.

            //Set text to '*' if not checked.
            if (chkShowPwd.Checked.Equals(false))
            {
                txtPassword.PasswordChar = '*';
            }

            //Set text to normal characters if checked.
            else if(chkShowPwd.Checked.Equals(true))
            {
                //Reference: Assistance with reset PasswordChar to original text.
                //http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/cb103ab6-f242-4f19-a21b-7d30fbfa8350/
                txtPassword.PasswordChar = '\0';                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the dialog on clicking cancel.
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Assign a password for login to a string.
            string password = "password";

            //Check if password is correct;
            if (txtPassword.Text.Equals(password))
            {
                //If correct show Add Vehicle form.
                dlgAddVehicle = new frmAddVehicle();

                dlgAddVehicle.ShowDialog();
            }//if
            else
            {
                //Notify user if password doesn't match.
                MessageBox.Show("Incorrect Password"+"\r\n"+"\r\n"+"(Try 'Password')");
            }//else
        }
    }
}
