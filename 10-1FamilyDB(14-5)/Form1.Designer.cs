namespace _10_1FamilyDB_14_5_
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
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyDataSet = new _10_1FamilyDB_14_5_.FamilyDataSet();
            this.familyTableAdapter = new _10_1FamilyDB_14_5_.FamilyDataSetTableAdapters.FamilyTableAdapter();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "Family";
            this.familyBindingSource.DataSource = this.familyDataSet;
            // 
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "FamilyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 419);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 19);
            this.lblMessage.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(179, 46);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(206, 60);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Find family that lives in the same hometown as you";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Results from Family Database";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 184);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtName.Size = new System.Drawing.Size(136, 51);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Names:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Relationships:";
            // 
            // txtRel
            // 
            this.txtRel.Location = new System.Drawing.Point(315, 184);
            this.txtRel.Multiline = true;
            this.txtRel.Name = "txtRel";
            this.txtRel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRel.Size = new System.Drawing.Size(136, 51);
            this.txtRel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(572, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Family Database 14-5";
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FamilyDataSet familyDataSet;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private FamilyDataSetTableAdapters.FamilyTableAdapter familyTableAdapter;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRel;
    }
}

