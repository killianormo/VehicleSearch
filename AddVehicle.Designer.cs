namespace VehicleSearch
{
    partial class frmAddVehicle
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
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.cbxColour = new System.Windows.Forms.ComboBox();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(27, 68);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(27, 93);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(27, 119);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 2;
            this.lblColour.Text = "Colour";
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(27, 45);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(67, 13);
            this.lblRegNumber.TabIndex = 3;
            this.lblRegNumber.Text = "Reg Number";
            // 
            // cbxColour
            // 
            this.cbxColour.FormattingEnabled = true;
            this.cbxColour.Location = new System.Drawing.Point(115, 118);
            this.cbxColour.Name = "cbxColour";
            this.cbxColour.Size = new System.Drawing.Size(132, 21);
            this.cbxColour.TabIndex = 12;
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(115, 38);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(132, 20);
            this.txtRegNumber.TabIndex = 9;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(115, 64);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(132, 20);
            this.txtMake.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(115, 92);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(132, 20);
            this.txtModel.TabIndex = 11;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(36, 155);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(91, 26);
            this.btnAddVehicle.TabIndex = 13;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(115, 13);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(132, 20);
            this.txtOwnerID.TabIndex = 8;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(27, 20);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(52, 13);
            this.lblOwnerID.TabIndex = 14;
            this.lblOwnerID.Text = "Owner ID";
            // 
            // frmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.cbxColour);
            this.Controls.Add(this.lblRegNumber);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Name = "frmAddVehicle";
            this.Text = "AddVehicle";
            this.Load += new System.EventHandler(this.frmAddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.ComboBox cbxColour;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label lblOwnerID;
    }
}