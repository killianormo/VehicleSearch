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
    public partial class frmAddVehicle : Form
    {
        //Assign variables for vehicle details.
        string regNo, make, model, colour;
        int ownerID;

        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //Initialise the variables.
            //Parse ownerID to string.
            regNo = txtRegNumber.Text;
            make = txtMake.Text;
            model = txtModel.Text;
            colour = cbxColour.SelectedItem.ToString();
            ownerID = Int32.Parse(txtOwnerID.Text);

        try
        {
            //Create a connection string.
            string connnectString = "server=127.0.0.1;" + "uid=root;" + "pwd=password;" + "database=vehicles;";

            //Connect to the database.
            MySqlConnection connect = new MySqlConnection(connnectString);

            //Set the text for command.
            string sqlInsert = "INSERT INTO registrations values ('" + regNo + "', '" + make + "','" +
                model + "', '" + colour + "', '" + ownerID + "');";

            //Create a mySql command.
            MySqlCommand command = new MySqlCommand(sqlInsert, connect);

            //Open the connection.
            connect.Open();

            //Reference: Assistance with adding vehicle to database.
            //http://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand.executenonquery(v=vs.71).aspx
           
            int selectInsert = command.ExecuteNonQuery();

            //Inform user of success.
            MessageBox.Show("Success: Record Inserted");

            //Close connection.
            connect.Close();
           
        }
                

            catch (MySqlException ex)
            {
                //Show exception.
                MessageBox.Show(ex.ToString() + "Databse Exception");
            }
            

        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {
            //Populate the combo box with colours.
            cbxColour.Items.Add("Black");
            cbxColour.Items.Add("Blue");
            cbxColour.Items.Add("Red");
            cbxColour.Items.Add("Silver");
            cbxColour.Items.Add("White");
        }
    }
}
