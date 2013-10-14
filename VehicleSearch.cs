using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Add MySql.Data as a reference.
using MySql.Data.MySqlClient;

namespace VehicleSearch
{
    public partial class frmVehicleSearch : Form
    {
        //Create variables for car details.
        string regNumber, make, model, colour, ID;
              
        frmAddVehicleLogin dlgAddVehLogin;

        public frmVehicleSearch()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //Call constructor using 'new'.
            dlgAddVehLogin = new frmAddVehicleLogin();

            //Show the address book box.
            dlgAddVehLogin.ShowDialog();

        }

        private void btnSearchReg_Click(object sender, EventArgs e)
        {
            //Clear the previous results.
            txtShowVehicleList.Clear();
            
            //Search for the vehicle by registration.

            //Create a connection string.
            string connnectString = "server=127.0.0.1;" + "uid=root;" + "pwd=password;" + "database=vehicles;";

            //Connect to the database.
            MySqlConnection connect = new MySqlConnection(connnectString);
                      
            //Build the SQL query string.
            string sqlSearch = "select * from registrations where ID like " + "'%" + txtRegInput.Text + "%';";

            //Create a mySql command.
            MySqlCommand command = connect.CreateCommand();

            //Set the text for command.
            command.CommandText = sqlSearch;

            //Notify user if no entry.
            if (txtRegInput.Text.Trim().Length == 0)
            {
                txtShowVehicleList.Text = "No vehicle match for entry";
            }

            else
            {

                try
                {
                    //Open the connection.
                    connect.Open();

                    //Create a mySQL data reader and activate it
                    MySqlDataReader reader = command.ExecuteReader();

                    //Assign variable to count vehicles found.
                    int count = 0;

                    //Get the data.
                    while (reader.Read())
                    {
                        //Increment the count.                    
                        count = count + 1;

                        //Show the count.
                        lblShowCount.Text = count.ToString();

                        //Assign variables to show car details.
                        regNumber = reader.GetValue(0).ToString() + ", ";
                        make = reader.GetValue(1).ToString() + ", ";
                        model = reader.GetValue(2).ToString() + ", ";
                        colour = reader.GetValue(3).ToString() + ", ";
                        ID = reader.GetValue(4).ToString() + ", ";

                        //Show the results in the text box.
                        txtShowVehicleList.Text += "Vehicle found" + "\r\n" + "Registration number: " + regNumber + "\r\n"
                             + "Make: " + make + "\r\n" + "Model: " + model + "\r\n" + "Colour: " + colour + "\r\n" + "ID: "
                             + ID + "\r\n" + "\r\n";

                    }//while

                    connect.Close();

                }//try
                catch (MySqlException ex)
                {
                    //Show exception.
                    MessageBox.Show(ex.ToString(), "Database Exception");
                }
            }//else
        }

        private void cbxColourInput_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmVehicleSearch_Load(object sender, EventArgs e)
        {
            //Populate the combo box with colours.
            cbxColourInput.Items.Add("Black");
            cbxColourInput.Items.Add("Blue");
            cbxColourInput.Items.Add("Red");
            cbxColourInput.Items.Add("Silver");
            cbxColourInput.Items.Add("White");
        }

        private void btnSearchColour_Click(object sender, EventArgs e)
        {
            //Clear the previous results.
            txtShowVehicleList.Clear();
                
            //Search for the vehicle by colour.

            //Create a connection string.
            string connnectString = "server=127.0.0.1;" + "uid=root;" + "pwd=password;" + "database=vehicles;";

            //Connect to the database.
            MySqlConnection connect = new MySqlConnection(connnectString);

            //Build the SQL query string.
            string sqlSearch = "select * from registrations where Colour like "+"'%" + cbxColourInput.Text + "%';";
            
            //Create a mySql command.
            MySqlCommand command = connect.CreateCommand();

            //Set the text for command.
            command.CommandText = sqlSearch;

            //Notify user if no entry.
            if (cbxColourInput.Text.Trim().Length == 0)
            {
                txtShowVehicleList.Text = "No vehicle match for entry";
            }

            else
            {
                try
                {
                    //Open the connection.
                    connect.Open();

                    //Create a mySQL data reader and activate it
                    MySqlDataReader reader = command.ExecuteReader();

                    //Assign variable to count vehicles found.
                    int count = 0;

                    //Get the data.
                    while (reader.Read())
                    {
                        //Increment the count.
                        count = count + 1;

                        //Show the count.
                        lblShowCount.Text = count.ToString();

                        //Assign variables to show car details.
                        regNumber = reader.GetValue(0).ToString() + ", ";
                        make = reader.GetValue(1).ToString() + ", ";
                        model = reader.GetValue(2).ToString() + ", ";
                        colour = reader.GetValue(3).ToString() + ", ";
                        ID = reader.GetValue(4).ToString() + ", ";

                        //Show the results in the text box.
                        txtShowVehicleList.Text += "Vehicle found" + "\r\n" + "Registration number: " + regNumber + "\r\n"
                            + "Make: " + make + "\r\n" + "Model: " + model + "\r\n" + "Colour: " + colour + "\r\n" + "ID: "
                            + ID + "\r\n" + "\r\n";


                    }//while

                    connect.Close();

                }//try
                catch (MySqlException ex)
                {
                    //Show exception.
                    MessageBox.Show(ex.ToString(), "Database Exception");
                }
            }//else
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the vehicle details in the text box.
            txtShowVehicleList.Clear();

            //Clear the label with the vehicles found count.
            lblShowCount.ResetText();

            //Clear the registration search box.
            txtRegInput.Clear();
                        
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Show my details on help button.
            MessageBox.Show("Name: Killian Ormond" + "\r\n" + "Student Number: 2840972" + "\r\n"
                + "HDCS-HGP" + "\r\n" + "Assignment 2: Vehicle Search");
        }
    }
}
