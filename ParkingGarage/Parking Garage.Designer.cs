namespace ParkingGarage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxTicketIn = new System.Windows.Forms.TextBox();
            this.txtbxTicketOut = new System.Windows.Forms.TextBox();
            this.lblFull = new System.Windows.Forms.Label();
            this.lblEnterTicket = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.txtbxCharge = new System.Windows.Forms.TextBox();
            this.btnSaveTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnter.FlatAppearance.BorderSize = 5;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(575, 219);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(127, 46);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(192, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnTickets.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTickets.FlatAppearance.BorderSize = 5;
            this.btnTickets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTickets.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTickets.ForeColor = System.Drawing.Color.Blue;
            this.btnTickets.Location = new System.Drawing.Point(377, 202);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(127, 80);
            this.btnTickets.TabIndex = 2;
            this.btnTickets.Text = "VIEW TICKETS";
            this.btnTickets.UseVisualStyleBackColor = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your ticket # is: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your ticket #: ";
            // 
            // txtbxTicketIn
            // 
            this.txtbxTicketIn.Enabled = false;
            this.txtbxTicketIn.Location = new System.Drawing.Point(623, 304);
            this.txtbxTicketIn.Name = "txtbxTicketIn";
            this.txtbxTicketIn.Size = new System.Drawing.Size(30, 20);
            this.txtbxTicketIn.TabIndex = 5;
            // 
            // txtbxTicketOut
            // 
            this.txtbxTicketOut.Location = new System.Drawing.Point(240, 304);
            this.txtbxTicketOut.Name = "txtbxTicketOut";
            this.txtbxTicketOut.Size = new System.Drawing.Size(30, 20);
            this.txtbxTicketOut.TabIndex = 6;
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.BackColor = System.Drawing.Color.Transparent;
            this.lblFull.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFull.ForeColor = System.Drawing.Color.Red;
            this.lblFull.Location = new System.Drawing.Point(219, 376);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(434, 39);
            this.lblFull.TabIndex = 7;
            this.lblFull.Text = "The parking garage is full!";
            this.lblFull.Visible = false;
            // 
            // lblEnterTicket
            // 
            this.lblEnterTicket.AutoSize = true;
            this.lblEnterTicket.BackColor = System.Drawing.Color.Red;
            this.lblEnterTicket.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTicket.Location = new System.Drawing.Point(146, 334);
            this.lblEnterTicket.Name = "lblEnterTicket";
            this.lblEnterTicket.Size = new System.Drawing.Size(219, 19);
            this.lblEnterTicket.TabIndex = 8;
            this.lblEnterTicket.Text = "You must enter your ticket #.";
            this.lblEnterTicket.Visible = false;
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(211, 138);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(83, 22);
            this.lblCharge.TabIndex = 9;
            this.lblCharge.Text = "You owe:";
            this.lblCharge.Visible = false;
            // 
            // txtbxCharge
            // 
            this.txtbxCharge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtbxCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxCharge.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCharge.Location = new System.Drawing.Point(222, 163);
            this.txtbxCharge.Name = "txtbxCharge";
            this.txtbxCharge.Size = new System.Drawing.Size(60, 25);
            this.txtbxCharge.TabIndex = 10;
            this.txtbxCharge.Visible = false;
            // 
            // btnSaveTickets
            // 
            this.btnSaveTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveTickets.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveTickets.FlatAppearance.BorderSize = 5;
            this.btnSaveTickets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSaveTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveTickets.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTickets.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSaveTickets.Location = new System.Drawing.Point(355, 3);
            this.btnSaveTickets.Name = "btnSaveTickets";
            this.btnSaveTickets.Size = new System.Drawing.Size(149, 33);
            this.btnSaveTickets.TabIndex = 11;
            this.btnSaveTickets.Text = "SAVE TICKETS";
            this.btnSaveTickets.UseVisualStyleBackColor = false;
            this.btnSaveTickets.Click += new System.EventHandler(this.btnSaveTickets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 486);
            this.Controls.Add(this.btnSaveTickets);
            this.Controls.Add(this.txtbxCharge);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblEnterTicket);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.txtbxTicketOut);
            this.Controls.Add(this.txtbxTicketIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTickets);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Parking Garage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxTicketIn;
        private System.Windows.Forms.TextBox txtbxTicketOut;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Label lblEnterTicket;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.TextBox txtbxCharge;
        private System.Windows.Forms.Button btnSaveTickets;
    }
}

