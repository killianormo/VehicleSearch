namespace World_Email2
{
    partial class frmWorldEmail
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
            this.grpMailSender = new System.Windows.Forms.GroupBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.lblFromName = new System.Windows.Forms.Label();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.grpMailRecipient = new System.Windows.Forms.GroupBox();
            this.lstEmailTo = new System.Windows.Forms.ListBox();
            this.lstNameTo = new System.Windows.Forms.ListBox();
            this.btnAddresses = new System.Windows.Forms.Button();
            this.lblToEmail = new System.Windows.Forms.Label();
            this.lblToName = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.chbEchoResponse = new System.Windows.Forms.CheckBox();
            this.txtEmailServer = new System.Windows.Forms.ComboBox();
            this.lblEmailServer = new System.Windows.Forms.Label();
            this.grpMailSender.SuspendLayout();
            this.grpMailRecipient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMailSender
            // 
            this.grpMailSender.Controls.Add(this.lblSubject);
            this.grpMailSender.Controls.Add(this.txtSubject);
            this.grpMailSender.Controls.Add(this.txtFromEmail);
            this.grpMailSender.Controls.Add(this.lblFromEmail);
            this.grpMailSender.Controls.Add(this.lblFromName);
            this.grpMailSender.Controls.Add(this.txtFromName);
            this.grpMailSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMailSender.Location = new System.Drawing.Point(30, 20);
            this.grpMailSender.Name = "grpMailSender";
            this.grpMailSender.Size = new System.Drawing.Size(372, 108);
            this.grpMailSender.TabIndex = 0;
            this.grpMailSender.TabStop = false;
            this.grpMailSender.Text = "Mail Sender";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(75, 73);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(124, 70);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(235, 20);
            this.txtSubject.TabIndex = 10;
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromEmail.Location = new System.Drawing.Point(124, 44);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(235, 20);
            this.txtFromEmail.TabIndex = 9;
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromEmail.Location = new System.Drawing.Point(13, 47);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(108, 13);
            this.lblFromEmail.TabIndex = 8;
            this.lblFromEmail.Text = "From (Email Address):";
            // 
            // lblFromName
            // 
            this.lblFromName.AutoSize = true;
            this.lblFromName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromName.Location = new System.Drawing.Point(51, 21);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(70, 13);
            this.lblFromName.TabIndex = 7;
            this.lblFromName.Text = "From (Name):";
            // 
            // txtFromName
            // 
            this.txtFromName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromName.Location = new System.Drawing.Point(124, 18);
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.Size = new System.Drawing.Size(235, 20);
            this.txtFromName.TabIndex = 6;
            // 
            // grpMailRecipient
            // 
            this.grpMailRecipient.Controls.Add(this.lstEmailTo);
            this.grpMailRecipient.Controls.Add(this.lstNameTo);
            this.grpMailRecipient.Controls.Add(this.btnAddresses);
            this.grpMailRecipient.Controls.Add(this.lblToEmail);
            this.grpMailRecipient.Controls.Add(this.lblToName);
            this.grpMailRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMailRecipient.Location = new System.Drawing.Point(30, 143);
            this.grpMailRecipient.Name = "grpMailRecipient";
            this.grpMailRecipient.Size = new System.Drawing.Size(372, 84);
            this.grpMailRecipient.TabIndex = 1;
            this.grpMailRecipient.TabStop = false;
            this.grpMailRecipient.Text = "Mail Recipient";
            this.grpMailRecipient.Enter += new System.EventHandler(this.grpMailRecipient_Enter);
            // 
            // lstEmailTo
            // 
            this.lstEmailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmailTo.FormattingEnabled = true;
            this.lstEmailTo.Location = new System.Drawing.Point(155, 43);
            this.lstEmailTo.Name = "lstEmailTo";
            this.lstEmailTo.Size = new System.Drawing.Size(204, 17);
            this.lstEmailTo.TabIndex = 12;
            // 
            // lstNameTo
            // 
            this.lstNameTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNameTo.FormattingEnabled = true;
            this.lstNameTo.Location = new System.Drawing.Point(124, 20);
            this.lstNameTo.Name = "lstNameTo";
            this.lstNameTo.Size = new System.Drawing.Size(235, 17);
            this.lstNameTo.TabIndex = 11;
            // 
            // btnAddresses
            // 
            this.btnAddresses.Location = new System.Drawing.Point(125, 43);
            this.btnAddresses.Name = "btnAddresses";
            this.btnAddresses.Size = new System.Drawing.Size(24, 21);
            this.btnAddresses.TabIndex = 10;
            this.btnAddresses.Text = "...";
            this.btnAddresses.UseVisualStyleBackColor = true;
            this.btnAddresses.Click += new System.EventHandler(this.btnAddresses_Click);
            // 
            // lblToEmail
            // 
            this.lblToEmail.AutoSize = true;
            this.lblToEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToEmail.Location = new System.Drawing.Point(13, 47);
            this.lblToEmail.Name = "lblToEmail";
            this.lblToEmail.Size = new System.Drawing.Size(98, 13);
            this.lblToEmail.TabIndex = 9;
            this.lblToEmail.Text = "To (Email Address):";
            // 
            // lblToName
            // 
            this.lblToName.AutoSize = true;
            this.lblToName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToName.Location = new System.Drawing.Point(51, 21);
            this.lblToName.Name = "lblToName";
            this.lblToName.Size = new System.Drawing.Size(60, 13);
            this.lblToName.TabIndex = 8;
            this.lblToName.Text = "To (Name):";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(46, 233);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(333, 152);
            this.txtMessage.TabIndex = 16;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(351, 443);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(77, 23);
            this.btnAbout.TabIndex = 15;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(351, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(256, 405);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chbEchoResponse
            // 
            this.chbEchoResponse.AutoSize = true;
            this.chbEchoResponse.Checked = true;
            this.chbEchoResponse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEchoResponse.Location = new System.Drawing.Point(39, 432);
            this.chbEchoResponse.Name = "chbEchoResponse";
            this.chbEchoResponse.Size = new System.Drawing.Size(136, 17);
            this.chbEchoResponse.TabIndex = 12;
            this.chbEchoResponse.Text = "Echo Server Response";
            this.chbEchoResponse.UseVisualStyleBackColor = true;
            // 
            // txtEmailServer
            // 
            this.txtEmailServer.FormattingEnabled = true;
            this.txtEmailServer.Location = new System.Drawing.Point(94, 405);
            this.txtEmailServer.Name = "txtEmailServer";
            this.txtEmailServer.Size = new System.Drawing.Size(127, 21);
            this.txtEmailServer.TabIndex = 11;
            // 
            // lblEmailServer
            // 
            this.lblEmailServer.AutoSize = true;
            this.lblEmailServer.Location = new System.Drawing.Point(13, 405);
            this.lblEmailServer.Name = "lblEmailServer";
            this.lblEmailServer.Size = new System.Drawing.Size(63, 13);
            this.lblEmailServer.TabIndex = 10;
            this.lblEmailServer.Text = "EmailServer";
            // 
            // frmWorldEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 480);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chbEchoResponse);
            this.Controls.Add(this.txtEmailServer);
            this.Controls.Add(this.lblEmailServer);
            this.Controls.Add(this.grpMailRecipient);
            this.Controls.Add(this.grpMailSender);
            this.Name = "frmWorldEmail";
            this.Text = "World Email";
            this.Load += new System.EventHandler(this.frmWorldEmail_Load);
            this.grpMailSender.ResumeLayout(false);
            this.grpMailSender.PerformLayout();
            this.grpMailRecipient.ResumeLayout(false);
            this.grpMailRecipient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMailSender;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.GroupBox grpMailRecipient;
        private System.Windows.Forms.ListBox lstEmailTo;
        private System.Windows.Forms.ListBox lstNameTo;
        private System.Windows.Forms.Button btnAddresses;
        private System.Windows.Forms.Label lblToEmail;
        private System.Windows.Forms.Label lblToName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chbEchoResponse;
        private System.Windows.Forms.ComboBox txtEmailServer;
        private System.Windows.Forms.Label lblEmailServer;
    }
}

