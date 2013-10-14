using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//In completing this assignment I have used the notes from class lectures
//in addition, I used my existing knowledge from studying Java and a lot of trial and error.n 

namespace World_Email2
{
    public partial class frmWorldEmail : Form
    {
        //Create dialog instance.
        frmAddressBook dlgAddress;

        String names;
        String emails;


        public frmWorldEmail()
        {
            InitializeComponent();
        }

        public void btnAddresses_Click(object sender, EventArgs e)
        {
            //Call constructor using 'new'.
            dlgAddress = new frmAddressBook();

            //Show the address book box.
            dlgAddress.ShowDialog();

            this.names = dlgAddress.getName();
            lstNameTo.Items.Add(names);
            this.emails = dlgAddress.getEmail();
            lstEmailTo.Items.Add(emails);

            string nameFrom = "Killian Ormond";
            string emailFrom = "killianormond@email.com";
            
            txtFromName.Text = nameFrom;
            txtFromEmail.Text = emailFrom;
                                  
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Show my details in a message box on clicking 'About'.
            MessageBox.Show("Name:\t\tKillian Ormond\nStudent Number:\t2840972\nAssignment:\tWorld Email");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Exit the application on clicking 'Cancel'.
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Show message in message box on clicking 'Send'.
            //MessageBox.Show("For the purposes of this assignment,\nthis client is not required to connect to\na mail server or send an email.");

            //Instantiate a new SMTP client.
            SmtpClient client = new SmtpClient();

            client.Host = "smtp.gmail.com";

            //Create a new mail message.
        }

        private void frmWorldEmail_Load(object sender, EventArgs e)
        {
            //Show details of server box.
            string server = "smtp.worldmailcom.net";
            txtEmailServer.Text = server;
        }

        public void grpMailRecipient_Enter(object sender, EventArgs e)
        {
                      
        }

       
    }
}
