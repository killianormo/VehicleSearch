namespace VehicleSearch
{
    partial class frmVehicleSearch
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
            this.txtRegInput = new System.Windows.Forms.TextBox();
            this.lblRegInput = new System.Windows.Forms.Label();
            this.btnSearchReg = new System.Windows.Forms.Button();
            this.cbxColourInput = new System.Windows.Forms.ComboBox();
            this.btnSearchColour = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtShowVehicleList = new System.Windows.Forms.TextBox();
            this.lblShowCount = new System.Windows.Forms.Label();
            this.lblVehicleFound = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegInput
            // 
            this.txtRegInput.Location = new System.Drawing.Point(12, 37);
            this.txtRegInput.Name = "txtRegInput";
            this.txtRegInput.Size = new System.Drawing.Size(129, 20);
            this.txtRegInput.TabIndex = 0;
            // 
            // lblRegInput
            // 
            this.lblRegInput.AutoSize = true;
            this.lblRegInput.Location = new System.Drawing.Point(9, 12);
            this.lblRegInput.Name = "lblRegInput";
            this.lblRegInput.Size = new System.Drawing.Size(98, 13);
            this.lblRegInput.TabIndex = 1;
            this.lblRegInput.Text = "Enter Reg Number:";
            // 
            // btnSearchReg
            // 
            this.btnSearchReg.Location = new System.Drawing.Point(173, 34);
            this.btnSearchReg.Name = "btnSearchReg";
            this.btnSearchReg.Size = new System.Drawing.Size(83, 28);
            this.btnSearchReg.TabIndex = 2;
            this.btnSearchReg.Text = "Search Reg";
            this.btnSearchReg.UseVisualStyleBackColor = true;
            this.btnSearchReg.Click += new System.EventHandler(this.btnSearchReg_Click);
            // 
            // cbxColourInput
            // 
            this.cbxColourInput.FormattingEnabled = true;
            this.cbxColourInput.Location = new System.Drawing.Point(12, 73);
            this.cbxColourInput.Name = "cbxColourInput";
            this.cbxColourInput.Size = new System.Drawing.Size(129, 21);
            this.cbxColourInput.TabIndex = 3;
            this.cbxColourInput.SelectedIndexChanged += new System.EventHandler(this.cbxColourInput_SelectedIndexChanged);
            // 
            // btnSearchColour
            // 
            this.btnSearchColour.Location = new System.Drawing.Point(173, 68);
            this.btnSearchColour.Name = "btnSearchColour";
            this.btnSearchColour.Size = new System.Drawing.Size(83, 28);
            this.btnSearchColour.TabIndex = 4;
            this.btnSearchColour.Text = "Search Colour";
            this.btnSearchColour.UseVisualStyleBackColor = true;
            this.btnSearchColour.Click += new System.EventHandler(this.btnSearchColour_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(13, 111);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(130, 28);
            this.btnAddVehicle.TabIndex = 5;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(166, 337);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 28);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtShowVehicleList
            // 
            this.txtShowVehicleList.Location = new System.Drawing.Point(13, 157);
            this.txtShowVehicleList.Multiline = true;
            this.txtShowVehicleList.Name = "txtShowVehicleList";
            this.txtShowVehicleList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowVehicleList.Size = new System.Drawing.Size(243, 132);
            this.txtShowVehicleList.TabIndex = 9;
            // 
            // lblShowCount
            // 
            this.lblShowCount.AutoSize = true;
            this.lblShowCount.Location = new System.Drawing.Point(20, 305);
            this.lblShowCount.Name = "lblShowCount";
            this.lblShowCount.Size = new System.Drawing.Size(0, 13);
            this.lblShowCount.TabIndex = 10;
            // 
            // lblVehicleFound
            // 
            this.lblVehicleFound.AutoSize = true;
            this.lblVehicleFound.Location = new System.Drawing.Point(39, 305);
            this.lblVehicleFound.Name = "lblVehicleFound";
            this.lblVehicleFound.Size = new System.Drawing.Size(80, 13);
            this.lblVehicleFound.TabIndex = 11;
            this.lblVehicleFound.Text = "Vehicles Found";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(166, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(23, 337);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 28);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmVehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 385);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblVehicleFound);
            this.Controls.Add(this.lblShowCount);
            this.Controls.Add(this.txtShowVehicleList);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnSearchColour);
            this.Controls.Add(this.cbxColourInput);
            this.Controls.Add(this.btnSearchReg);
            this.Controls.Add(this.lblRegInput);
            this.Controls.Add(this.txtRegInput);
            this.Name = "frmVehicleSearch";
            this.Text = "Vehicle Search";
            this.Load += new System.EventHandler(this.frmVehicleSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegInput;
        private System.Windows.Forms.Label lblRegInput;
        private System.Windows.Forms.Button btnSearchReg;
        private System.Windows.Forms.ComboBox cbxColourInput;
        private System.Windows.Forms.Button btnSearchColour;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtShowVehicleList;
        private System.Windows.Forms.Label lblShowCount;
        private System.Windows.Forms.Label lblVehicleFound;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
    }
}

