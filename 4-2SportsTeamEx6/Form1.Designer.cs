namespace _4_1SportsTeamEx6
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblNumPlayers = new System.Windows.Forms.Label();
            this.lblSport = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtNumPlayers = new System.Windows.Forms.TextBox();
            this.cbxSport = new System.Windows.Forms.ComboBox();
            this.txtTeamType = new System.Windows.Forms.TextBox();
            this.lblTeamType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCoach = new System.Windows.Forms.TextBox();
            this.lblCoach = new System.Windows.Forms.Label();
            this.txtMascot = new System.Windows.Forms.TextBox();
            this.lblMascot = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtField = new System.Windows.Forms.TextBox();
            this.lblField = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSBWins = new System.Windows.Forms.TextBox();
            this.lblSBWins = new System.Windows.Forms.Label();
            this.txtSBAppear = new System.Windows.Forms.TextBox();
            this.lblSBAppear = new System.Windows.Forms.Label();
            this.txtLeague = new System.Windows.Forms.TextBox();
            this.lblLeague = new System.Windows.Forms.Label();
            this.pnlFootball = new System.Windows.Forms.Panel();
            this.pnlSoccer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTeam = new System.Windows.Forms.Panel();
            this.txtCoachSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEquipmentFees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFootball.SuspendLayout();
            this.pnlSoccer.SuspendLayout();
            this.pnlTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(69, 115);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(74, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Game Length:";
            // 
            // lblNumPlayers
            // 
            this.lblNumPlayers.AutoSize = true;
            this.lblNumPlayers.Location = new System.Drawing.Point(47, 143);
            this.lblNumPlayers.Name = "lblNumPlayers";
            this.lblNumPlayers.Size = new System.Drawing.Size(96, 13);
            this.lblNumPlayers.TabIndex = 1;
            this.lblNumPlayers.Text = "Number of Players:";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(111, 29);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(35, 13);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sport:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(149, 112);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(182, 20);
            this.txtLength.TabIndex = 4;
            // 
            // txtNumPlayers
            // 
            this.txtNumPlayers.Location = new System.Drawing.Point(149, 140);
            this.txtNumPlayers.Name = "txtNumPlayers";
            this.txtNumPlayers.Size = new System.Drawing.Size(182, 20);
            this.txtNumPlayers.TabIndex = 5;
            // 
            // cbxSport
            // 
            this.cbxSport.FormattingEnabled = true;
            this.cbxSport.Items.AddRange(new object[] {
            "Football",
            "Soccer"});
            this.cbxSport.Location = new System.Drawing.Point(152, 26);
            this.cbxSport.Name = "cbxSport";
            this.cbxSport.Size = new System.Drawing.Size(182, 21);
            this.cbxSport.TabIndex = 6;
            this.cbxSport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTeamType
            // 
            this.txtTeamType.Location = new System.Drawing.Point(149, 0);
            this.txtTeamType.Name = "txtTeamType";
            this.txtTeamType.Size = new System.Drawing.Size(182, 20);
            this.txtTeamType.TabIndex = 8;
            // 
            // lblTeamType
            // 
            this.lblTeamType.AutoSize = true;
            this.lblTeamType.Location = new System.Drawing.Point(64, 3);
            this.lblTeamType.Name = "lblTeamType";
            this.lblTeamType.Size = new System.Drawing.Size(76, 13);
            this.lblTeamType.TabIndex = 7;
            this.lblTeamType.Text = "Type of Team:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Team Name:";
            // 
            // txtCoach
            // 
            this.txtCoach.Location = new System.Drawing.Point(149, 56);
            this.txtCoach.Name = "txtCoach";
            this.txtCoach.Size = new System.Drawing.Size(182, 20);
            this.txtCoach.TabIndex = 12;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(64, 59);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(79, 13);
            this.lblCoach.TabIndex = 11;
            this.lblCoach.Text = "Coach\'s Name:";
            // 
            // txtMascot
            // 
            this.txtMascot.Location = new System.Drawing.Point(149, 84);
            this.txtMascot.Name = "txtMascot";
            this.txtMascot.Size = new System.Drawing.Size(182, 20);
            this.txtMascot.TabIndex = 14;
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Location = new System.Drawing.Point(98, 87);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(45, 13);
            this.lblMascot.TabIndex = 13;
            this.lblMascot.Text = "Mascot:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(149, 0);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(182, 20);
            this.txtCountry.TabIndex = 16;
            this.txtCountry.Tag = "Soccer";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(97, 3);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Tag = "Soccer";
            this.lblCountry.Text = "Country:";
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(149, 28);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(182, 20);
            this.txtField.TabIndex = 18;
            this.txtField.Tag = "Soccer";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(84, 31);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(59, 13);
            this.lblField.TabIndex = 17;
            this.lblField.Tag = "Soccer";
            this.lblField.Text = "Field Type:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(149, 56);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(182, 20);
            this.txtGender.TabIndex = 20;
            this.txtGender.Tag = "Soccer";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(49, 59);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(94, 13);
            this.lblGender.TabIndex = 19;
            this.lblGender.Tag = "Soccer";
            this.lblGender.Text = "Gender of Players:";
            // 
            // txtSBWins
            // 
            this.txtSBWins.Location = new System.Drawing.Point(149, 52);
            this.txtSBWins.Name = "txtSBWins";
            this.txtSBWins.Size = new System.Drawing.Size(182, 20);
            this.txtSBWins.TabIndex = 26;
            this.txtSBWins.Tag = "Football";
            // 
            // lblSBWins
            // 
            this.lblSBWins.AutoSize = true;
            this.lblSBWins.Location = new System.Drawing.Point(52, 55);
            this.lblSBWins.Name = "lblSBWins";
            this.lblSBWins.Size = new System.Drawing.Size(91, 13);
            this.lblSBWins.TabIndex = 25;
            this.lblSBWins.Tag = "Football";
            this.lblSBWins.Text = "Super Bowl Wins:";
            // 
            // txtSBAppear
            // 
            this.txtSBAppear.Location = new System.Drawing.Point(149, 26);
            this.txtSBAppear.Name = "txtSBAppear";
            this.txtSBAppear.Size = new System.Drawing.Size(182, 20);
            this.txtSBAppear.TabIndex = 24;
            this.txtSBAppear.Tag = "Football";
            // 
            // lblSBAppear
            // 
            this.lblSBAppear.AutoSize = true;
            this.lblSBAppear.Location = new System.Drawing.Point(13, 29);
            this.lblSBAppear.Name = "lblSBAppear";
            this.lblSBAppear.Size = new System.Drawing.Size(130, 13);
            this.lblSBAppear.TabIndex = 23;
            this.lblSBAppear.Tag = "Football";
            this.lblSBAppear.Text = "Super Bowl Appearances:";
            // 
            // txtLeague
            // 
            this.txtLeague.Location = new System.Drawing.Point(149, 0);
            this.txtLeague.Name = "txtLeague";
            this.txtLeague.Size = new System.Drawing.Size(182, 20);
            this.txtLeague.TabIndex = 22;
            this.txtLeague.Tag = "Football";
            // 
            // lblLeague
            // 
            this.lblLeague.AutoSize = true;
            this.lblLeague.Location = new System.Drawing.Point(97, 3);
            this.lblLeague.Name = "lblLeague";
            this.lblLeague.Size = new System.Drawing.Size(46, 13);
            this.lblLeague.TabIndex = 21;
            this.lblLeague.Tag = "Football";
            this.lblLeague.Text = "League:";
            // 
            // pnlFootball
            // 
            this.pnlFootball.Controls.Add(this.txtSBWins);
            this.pnlFootball.Controls.Add(this.lblSBWins);
            this.pnlFootball.Controls.Add(this.txtSBAppear);
            this.pnlFootball.Controls.Add(this.lblSBAppear);
            this.pnlFootball.Controls.Add(this.txtLeague);
            this.pnlFootball.Controls.Add(this.lblLeague);
            this.pnlFootball.Location = new System.Drawing.Point(75, 429);
            this.pnlFootball.Name = "pnlFootball";
            this.pnlFootball.Size = new System.Drawing.Size(339, 75);
            this.pnlFootball.TabIndex = 27;
            this.pnlFootball.Visible = false;
            // 
            // pnlSoccer
            // 
            this.pnlSoccer.Controls.Add(this.txtGender);
            this.pnlSoccer.Controls.Add(this.lblGender);
            this.pnlSoccer.Controls.Add(this.txtField);
            this.pnlSoccer.Controls.Add(this.lblField);
            this.pnlSoccer.Controls.Add(this.txtCountry);
            this.pnlSoccer.Controls.Add(this.lblCountry);
            this.pnlSoccer.Location = new System.Drawing.Point(3, 334);
            this.pnlSoccer.Name = "pnlSoccer";
            this.pnlSoccer.Size = new System.Drawing.Size(331, 77);
            this.pnlSoccer.TabIndex = 28;
            this.pnlSoccer.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlTeam
            // 
            this.pnlTeam.Controls.Add(this.txtEquipmentFees);
            this.pnlTeam.Controls.Add(this.label2);
            this.pnlTeam.Controls.Add(this.txtCoachSalary);
            this.pnlTeam.Controls.Add(this.label1);
            this.pnlTeam.Controls.Add(this.txtMascot);
            this.pnlTeam.Controls.Add(this.lblMascot);
            this.pnlTeam.Controls.Add(this.txtCoach);
            this.pnlTeam.Controls.Add(this.lblCoach);
            this.pnlTeam.Controls.Add(this.txtName);
            this.pnlTeam.Controls.Add(this.lblName);
            this.pnlTeam.Controls.Add(this.txtTeamType);
            this.pnlTeam.Controls.Add(this.lblTeamType);
            this.pnlTeam.Controls.Add(this.txtNumPlayers);
            this.pnlTeam.Controls.Add(this.txtLength);
            this.pnlTeam.Controls.Add(this.lblNumPlayers);
            this.pnlTeam.Controls.Add(this.lblLength);
            this.pnlTeam.Location = new System.Drawing.Point(3, 114);
            this.pnlTeam.Name = "pnlTeam";
            this.pnlTeam.Size = new System.Drawing.Size(334, 214);
            this.pnlTeam.TabIndex = 30;
            // 
            // txtCoachSalary
            // 
            this.txtCoachSalary.Location = new System.Drawing.Point(149, 166);
            this.txtCoachSalary.Name = "txtCoachSalary";
            this.txtCoachSalary.Size = new System.Drawing.Size(182, 20);
            this.txtCoachSalary.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Coach\'s Salary:";
            // 
            // txtEquipmentFees
            // 
            this.txtEquipmentFees.Location = new System.Drawing.Point(149, 192);
            this.txtEquipmentFees.Name = "txtEquipmentFees";
            this.txtEquipmentFees.Size = new System.Drawing.Size(182, 20);
            this.txtEquipmentFees.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Equipment Fees:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlSoccer);
            this.Controls.Add(this.pnlFootball);
            this.Controls.Add(this.cbxSport);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.pnlTeam);
            this.Name = "Form1";
            this.Text = "Team Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFootball.ResumeLayout(false);
            this.pnlFootball.PerformLayout();
            this.pnlSoccer.ResumeLayout(false);
            this.pnlSoccer.PerformLayout();
            this.pnlTeam.ResumeLayout(false);
            this.pnlTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblNumPlayers;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtNumPlayers;
        private System.Windows.Forms.ComboBox cbxSport;
        private System.Windows.Forms.TextBox txtTeamType;
        private System.Windows.Forms.Label lblTeamType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCoach;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.TextBox txtMascot;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtSBWins;
        private System.Windows.Forms.Label lblSBWins;
        private System.Windows.Forms.TextBox txtSBAppear;
        private System.Windows.Forms.Label lblSBAppear;
        private System.Windows.Forms.TextBox txtLeague;
        private System.Windows.Forms.Label lblLeague;
        private System.Windows.Forms.Panel pnlFootball;
        private System.Windows.Forms.Panel pnlSoccer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlTeam;
        private System.Windows.Forms.TextBox txtEquipmentFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoachSalary;
        private System.Windows.Forms.Label label1;
    }
}

