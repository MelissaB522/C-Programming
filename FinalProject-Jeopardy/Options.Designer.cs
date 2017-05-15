namespace FinalProject_Jeopardy
{
    partial class Options
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
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.lblP3 = new System.Windows.Forms.Label();
            this.txtP3Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPlayers
            // 
            this.cbPlayers.BackColor = System.Drawing.Color.MidnightBlue;
            this.cbPlayers.ForeColor = System.Drawing.Color.Ivory;
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.cbPlayers.Location = new System.Drawing.Point(15, 30);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(121, 26);
            this.cbPlayers.TabIndex = 0;
            this.cbPlayers.SelectedIndexChanged += new System.EventHandler(this.cbPlayers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many players?";
            // 
            // txtP1Name
            // 
            this.txtP1Name.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtP1Name.ForeColor = System.Drawing.Color.Ivory;
            this.txtP1Name.Location = new System.Drawing.Point(15, 99);
            this.txtP1Name.Name = "txtP1Name";
            this.txtP1Name.Size = new System.Drawing.Size(167, 26);
            this.txtP1Name.TabIndex = 2;
            this.txtP1Name.Visible = false;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(12, 78);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(113, 18);
            this.lblP1.TabIndex = 3;
            this.lblP1.Text = "Player 1 name:";
            this.lblP1.Visible = false;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(12, 139);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(116, 18);
            this.lblP2.TabIndex = 5;
            this.lblP2.Text = "Player 2 name:";
            this.lblP2.Visible = false;
            // 
            // txtP2Name
            // 
            this.txtP2Name.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtP2Name.ForeColor = System.Drawing.Color.Ivory;
            this.txtP2Name.Location = new System.Drawing.Point(15, 160);
            this.txtP2Name.Name = "txtP2Name";
            this.txtP2Name.Size = new System.Drawing.Size(167, 26);
            this.txtP2Name.TabIndex = 4;
            this.txtP2Name.Visible = false;
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Location = new System.Drawing.Point(12, 204);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(116, 18);
            this.lblP3.TabIndex = 7;
            this.lblP3.Text = "Player 3 name:";
            this.lblP3.Visible = false;
            // 
            // txtP3Name
            // 
            this.txtP3Name.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtP3Name.ForeColor = System.Drawing.Color.Ivory;
            this.txtP3Name.Location = new System.Drawing.Point(15, 225);
            this.txtP3Name.Name = "txtP3Name";
            this.txtP3Name.Size = new System.Drawing.Size(167, 26);
            this.txtP3Name.TabIndex = 6;
            this.txtP3Name.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(294, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.txtP3Name);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlayers);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Ivory;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.TextBox txtP3Name;
        private System.Windows.Forms.Button button1;
    }
}