namespace EmployeesApp
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.btnAdd_2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(122, 24);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(172, 22);
            this.txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(122, 68);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(172, 22);
            this.txtLname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Other information(Optional)";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(15, 142);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(279, 129);
            this.txtOther.TabIndex = 5;
            // 
            // btnAdd_2
            // 
            this.btnAdd_2.Location = new System.Drawing.Point(219, 110);
            this.btnAdd_2.Name = "btnAdd_2";
            this.btnAdd_2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_2.TabIndex = 6;
            this.btnAdd_2.Text = "Add";
            this.btnAdd_2.UseVisualStyleBackColor = true;
            this.btnAdd_2.Click += new System.EventHandler(this.btnAdd_2_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(80, 275);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(141, 17);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "ERROR: Invalid Input";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 301);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAdd_2);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtFname;
        public System.Windows.Forms.TextBox txtLname;
        public System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Button btnAdd_2;
        private System.Windows.Forms.Label lblError;
    }
}