namespace Exam1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutoLoan = new System.Windows.Forms.Button();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.btnPersonalLoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose your type of loan:";
            // 
            // btnAutoLoan
            // 
            this.btnAutoLoan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAutoLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoLoan.Location = new System.Drawing.Point(12, 98);
            this.btnAutoLoan.Name = "btnAutoLoan";
            this.btnAutoLoan.Size = new System.Drawing.Size(114, 38);
            this.btnAutoLoan.TabIndex = 2;
            this.btnAutoLoan.Text = "Auto Loan";
            this.btnAutoLoan.UseVisualStyleBackColor = false;
            this.btnAutoLoan.Click += new System.EventHandler(this.btnAutoLoan_Click);
            // 
            // btnMortgage
            // 
            this.btnMortgage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMortgage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMortgage.Location = new System.Drawing.Point(155, 98);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(114, 38);
            this.btnMortgage.TabIndex = 3;
            this.btnMortgage.Text = "Mortgage";
            this.btnMortgage.UseVisualStyleBackColor = false;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // btnPersonalLoan
            // 
            this.btnPersonalLoan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPersonalLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonalLoan.Location = new System.Drawing.Point(298, 98);
            this.btnPersonalLoan.Name = "btnPersonalLoan";
            this.btnPersonalLoan.Size = new System.Drawing.Size(114, 38);
            this.btnPersonalLoan.TabIndex = 4;
            this.btnPersonalLoan.Text = "Personal Loan";
            this.btnPersonalLoan.UseVisualStyleBackColor = false;
            this.btnPersonalLoan.Click += new System.EventHandler(this.btnPersonalLoan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(424, 179);
            this.Controls.Add(this.btnPersonalLoan);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.btnAutoLoan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Loan Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutoLoan;
        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.Button btnPersonalLoan;
    }
}

