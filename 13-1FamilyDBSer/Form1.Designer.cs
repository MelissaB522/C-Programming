namespace _13_1FamilyDBSer
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstbxFamily = new System.Windows.Forms.ListBox();
            this.lblNewFamily = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(127, 220);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(174, 59);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Family";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 507);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 1;
            // 
            // lstbxFamily
            // 
            this.lstbxFamily.FormattingEnabled = true;
            this.lstbxFamily.Location = new System.Drawing.Point(129, 297);
            this.lstbxFamily.Name = "lstbxFamily";
            this.lstbxFamily.Size = new System.Drawing.Size(170, 108);
            this.lstbxFamily.TabIndex = 2;
            // 
            // lblNewFamily
            // 
            this.lblNewFamily.AutoSize = true;
            this.lblNewFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFamily.Location = new System.Drawing.Point(88, 26);
            this.lblNewFamily.Name = "lblNewFamily";
            this.lblNewFamily.Size = new System.Drawing.Size(253, 25);
            this.lblNewFamily.TabIndex = 3;
            this.lblNewFamily.Text = "Enter new family member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Relationship:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(123, 74);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(182, 20);
            this.txtFirst.TabIndex = 7;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(123, 106);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(182, 20);
            this.txtLast.TabIndex = 8;
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(123, 138);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(182, 20);
            this.txtRelationship.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(324, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 63);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add family\r\nmember";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(471, 430);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRelationship);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewFamily);
            this.Controls.Add(this.lstbxFamily);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Family Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox lstbxFamily;
        private System.Windows.Forms.Label lblNewFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.Button btnAdd;
    }
}

