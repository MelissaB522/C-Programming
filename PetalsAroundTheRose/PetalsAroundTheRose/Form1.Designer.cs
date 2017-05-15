namespace PetalsAroundTheRose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TBTotalRolls = new System.Windows.Forms.TextBox();
            this.TBBestrun = new System.Windows.Forms.TextBox();
            this.LblRolls = new System.Windows.Forms.Label();
            this.LblCorrect = new System.Windows.Forms.Label();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBincorrectguesses = new System.Windows.Forms.TextBox();
            this.TBcorrectguesses = new System.Windows.Forms.TextBox();
            this.LblEnter = new System.Windows.Forms.Label();
            this.TBPlayerGuess = new System.Windows.Forms.TextBox();
            this.LblInput = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TBCurrentrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "face.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            // 
            // TBTotalRolls
            // 
            this.TBTotalRolls.BackColor = System.Drawing.Color.Silver;
            this.TBTotalRolls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTotalRolls.Location = new System.Drawing.Point(642, 65);
            this.TBTotalRolls.Name = "TBTotalRolls";
            this.TBTotalRolls.ReadOnly = true;
            this.TBTotalRolls.Size = new System.Drawing.Size(30, 20);
            this.TBTotalRolls.TabIndex = 0;
            // 
            // TBBestrun
            // 
            this.TBBestrun.BackColor = System.Drawing.Color.Silver;
            this.TBBestrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBestrun.Location = new System.Drawing.Point(642, 118);
            this.TBBestrun.Name = "TBBestrun";
            this.TBBestrun.ReadOnly = true;
            this.TBBestrun.Size = new System.Drawing.Size(30, 20);
            this.TBBestrun.TabIndex = 1;
            // 
            // LblRolls
            // 
            this.LblRolls.AutoSize = true;
            this.LblRolls.BackColor = System.Drawing.Color.White;
            this.LblRolls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRolls.Location = new System.Drawing.Point(565, 66);
            this.LblRolls.Name = "LblRolls";
            this.LblRolls.Size = new System.Drawing.Size(71, 19);
            this.LblRolls.TabIndex = 2;
            this.LblRolls.Text = "Total rolls:";
            // 
            // LblCorrect
            // 
            this.LblCorrect.AutoSize = true;
            this.LblCorrect.BackColor = System.Drawing.Color.White;
            this.LblCorrect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorrect.Location = new System.Drawing.Point(550, 119);
            this.LblCorrect.Name = "LblCorrect";
            this.LblCorrect.Size = new System.Drawing.Size(86, 19);
            this.LblCorrect.TabIndex = 3;
            this.LblCorrect.Text = "BEST RUN:";
            // 
            // BtnRoll
            // 
            this.BtnRoll.BackColor = System.Drawing.Color.Firebrick;
            this.BtnRoll.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoll.Location = new System.Drawing.Point(287, 97);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(182, 83);
            this.BtnRoll.TabIndex = 4;
            this.BtnRoll.Text = "ROLL DICE";
            this.BtnRoll.UseVisualStyleBackColor = false;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.InitialImage = global::PetalsAroundTheRose.Properties.Resources._0_border;
            this.pictureBox5.Location = new System.Drawing.Point(130, 260);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.InitialImage = global::PetalsAroundTheRose.Properties.Resources._0_border;
            this.pictureBox4.Location = new System.Drawing.Point(130, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.InitialImage = global::PetalsAroundTheRose.Properties.Resources._0_border;
            this.pictureBox3.Location = new System.Drawing.Point(15, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.InitialImage = global::PetalsAroundTheRose.Properties.Resources._0_border;
            this.pictureBox2.Location = new System.Drawing.Point(15, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = global::PetalsAroundTheRose.Properties.Resources._0_border;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "# Incorrect:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "# Correct:";
            // 
            // TBincorrectguesses
            // 
            this.TBincorrectguesses.BackColor = System.Drawing.Color.Silver;
            this.TBincorrectguesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBincorrectguesses.Location = new System.Drawing.Point(642, 39);
            this.TBincorrectguesses.Name = "TBincorrectguesses";
            this.TBincorrectguesses.ReadOnly = true;
            this.TBincorrectguesses.Size = new System.Drawing.Size(30, 20);
            this.TBincorrectguesses.TabIndex = 11;
            // 
            // TBcorrectguesses
            // 
            this.TBcorrectguesses.BackColor = System.Drawing.Color.Silver;
            this.TBcorrectguesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBcorrectguesses.Location = new System.Drawing.Point(642, 12);
            this.TBcorrectguesses.Name = "TBcorrectguesses";
            this.TBcorrectguesses.ReadOnly = true;
            this.TBcorrectguesses.Size = new System.Drawing.Size(30, 20);
            this.TBcorrectguesses.TabIndex = 10;
            // 
            // LblEnter
            // 
            this.LblEnter.AutoSize = true;
            this.LblEnter.BackColor = System.Drawing.Color.White;
            this.LblEnter.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnter.Location = new System.Drawing.Point(283, 192);
            this.LblEnter.Name = "LblEnter";
            this.LblEnter.Size = new System.Drawing.Size(186, 24);
            this.LblEnter.TabIndex = 15;
            this.LblEnter.Text = "Enter your guess:";
            // 
            // TBPlayerGuess
            // 
            this.TBPlayerGuess.BackColor = System.Drawing.Color.Silver;
            this.TBPlayerGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPlayerGuess.Location = new System.Drawing.Point(287, 229);
            this.TBPlayerGuess.MaxLength = 4;
            this.TBPlayerGuess.Name = "TBPlayerGuess";
            this.TBPlayerGuess.Size = new System.Drawing.Size(85, 20);
            this.TBPlayerGuess.TabIndex = 14;
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.BackColor = System.Drawing.Color.White;
            this.LblInput.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInput.Location = new System.Drawing.Point(320, 260);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(12, 20);
            this.LblInput.TabIndex = 16;
            this.LblInput.Text = " ";
            this.LblInput.Visible = false;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEnter.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.Location = new System.Drawing.Point(384, 219);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(85, 38);
            this.BtnEnter.TabIndex = 17;
            this.BtnEnter.Text = "ENTER";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Current Run:";
            // 
            // TBCurrentrun
            // 
            this.TBCurrentrun.BackColor = System.Drawing.Color.Silver;
            this.TBCurrentrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCurrentrun.Location = new System.Drawing.Point(642, 92);
            this.TBCurrentrun.Name = "TBCurrentrun";
            this.TBCurrentrun.ReadOnly = true;
            this.TBCurrentrun.Size = new System.Drawing.Size(30, 20);
            this.TBCurrentrun.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(213, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 80);
            this.label3.TabIndex = 20;
            this.label3.Text = "What\'s in a name? \r\nThe name of the game is \r\nPetals Around The Rose. \r\nThe name " +
    "of the game is important.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::PetalsAroundTheRose.Properties.Resources.Roses;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBCurrentrun);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.LblEnter);
            this.Controls.Add(this.TBPlayerGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBincorrectguesses);
            this.Controls.Add(this.TBcorrectguesses);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.LblCorrect);
            this.Controls.Add(this.LblRolls);
            this.Controls.Add(this.TBBestrun);
            this.Controls.Add(this.TBTotalRolls);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Petals Around The Rose";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox TBTotalRolls;
        private System.Windows.Forms.TextBox TBBestrun;
        private System.Windows.Forms.Label LblRolls;
        private System.Windows.Forms.Label LblCorrect;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label LblEnter;
        private System.Windows.Forms.TextBox TBPlayerGuess;
        private System.Windows.Forms.TextBox TBcorrectguesses;
        private System.Windows.Forms.TextBox TBincorrectguesses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCurrentrun;
        private System.Windows.Forms.Label label3;
    }
}

