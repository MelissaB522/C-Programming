namespace FinalProject_Jeopardy
{
    partial class AandQ
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnPlayer3 = new System.Windows.Forms.Button();
            this.txtPlayerAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnEnterAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 9);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(49, 18);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Value";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 18);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtQuestion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.Ivory;
            this.txtQuestion.Location = new System.Drawing.Point(15, 53);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.ShortcutsEnabled = false;
            this.txtQuestion.Size = new System.Drawing.Size(335, 171);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlayer1.FlatAppearance.BorderSize = 5;
            this.btnPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayer1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1.Location = new System.Drawing.Point(12, 259);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(93, 34);
            this.btnPlayer1.TabIndex = 3;
            this.btnPlayer1.Text = "Player 1";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlayer2.FlatAppearance.BorderSize = 5;
            this.btnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayer2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2.Location = new System.Drawing.Point(134, 259);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(93, 34);
            this.btnPlayer2.TabIndex = 4;
            this.btnPlayer2.Text = "Player 2";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // btnPlayer3
            // 
            this.btnPlayer3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlayer3.FlatAppearance.BorderSize = 5;
            this.btnPlayer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayer3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer3.Location = new System.Drawing.Point(256, 259);
            this.btnPlayer3.Name = "btnPlayer3";
            this.btnPlayer3.Size = new System.Drawing.Size(93, 34);
            this.btnPlayer3.TabIndex = 5;
            this.btnPlayer3.Text = "Player 3";
            this.btnPlayer3.UseVisualStyleBackColor = true;
            this.btnPlayer3.Click += new System.EventHandler(this.btnPlayer3_Click);
            // 
            // txtPlayerAnswer
            // 
            this.txtPlayerAnswer.Location = new System.Drawing.Point(12, 326);
            this.txtPlayerAnswer.Name = "txtPlayerAnswer";
            this.txtPlayerAnswer.Size = new System.Drawing.Size(337, 26);
            this.txtPlayerAnswer.TabIndex = 7;
            this.txtPlayerAnswer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Choose player:";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 305);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(232, 18);
            this.lblPrompt.TabIndex = 8;
            this.lblPrompt.Text = "Entry in the form of a question:";
            this.lblPrompt.Visible = false;
            // 
            // btnEnterAnswer
            // 
            this.btnEnterAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnterAnswer.Location = new System.Drawing.Point(143, 359);
            this.btnEnterAnswer.Name = "btnEnterAnswer";
            this.btnEnterAnswer.Size = new System.Drawing.Size(75, 34);
            this.btnEnterAnswer.TabIndex = 6;
            this.btnEnterAnswer.Text = "ENTER";
            this.btnEnterAnswer.UseVisualStyleBackColor = true;
            this.btnEnterAnswer.Visible = false;
            this.btnEnterAnswer.Click += new System.EventHandler(this.btnEnterAnswer_Click);
            // 
            // AandQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(361, 405);
            this.Controls.Add(this.btnEnterAnswer);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerAnswer);
            this.Controls.Add(this.btnPlayer3);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Ivory;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AandQ";
            this.Text = "AandQ";
            this.Load += new System.EventHandler(this.AandQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnPlayer3;
        private System.Windows.Forms.TextBox txtPlayerAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnEnterAnswer;
    }
}