namespace SchoolSmallSystem
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
            this.btnADD = new System.Windows.Forms.Button();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxsalary = new System.Windows.Forms.TextBox();
            this.typeemployee = new System.Windows.Forms.ComboBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelsalary = new System.Windows.Forms.Label();
            this.labeltypeemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelcountemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsumesal = new System.Windows.Forms.Label();
            this.LableTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.Gray;
            this.btnADD.Location = new System.Drawing.Point(657, 365);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(219, 70);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "ADD PERSON";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.BackColor = System.Drawing.Color.White;
            this.textBoxname.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.ForeColor = System.Drawing.Color.Black;
            this.textBoxname.Location = new System.Drawing.Point(202, 138);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(367, 38);
            this.textBoxname.TabIndex = 1;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.Black;
            this.textBoxID.Location = new System.Drawing.Point(202, 189);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(367, 42);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxsalary
            // 
            this.textBoxsalary.BackColor = System.Drawing.Color.White;
            this.textBoxsalary.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsalary.ForeColor = System.Drawing.Color.Black;
            this.textBoxsalary.Location = new System.Drawing.Point(202, 249);
            this.textBoxsalary.Multiline = true;
            this.textBoxsalary.Name = "textBoxsalary";
            this.textBoxsalary.Size = new System.Drawing.Size(367, 38);
            this.textBoxsalary.TabIndex = 3;
            this.textBoxsalary.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // typeemployee
            // 
            this.typeemployee.BackColor = System.Drawing.Color.White;
            this.typeemployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeemployee.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeemployee.ForeColor = System.Drawing.Color.Black;
            this.typeemployee.FormattingEnabled = true;
            this.typeemployee.Items.AddRange(new object[] {
            "Teachers",
            "HumanDepartments",
            "Manager"});
            this.typeemployee.Location = new System.Drawing.Point(203, 308);
            this.typeemployee.Name = "typeemployee";
            this.typeemployee.Size = new System.Drawing.Size(367, 44);
            this.typeemployee.TabIndex = 4;
            this.typeemployee.SelectedIndexChanged += new System.EventHandler(this.typeemployee_SelectedIndexChanged);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.White;
            this.labelname.Location = new System.Drawing.Point(39, 138);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(112, 36);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "The Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.White;
            this.labelid.Location = new System.Drawing.Point(43, 194);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(48, 36);
            this.labelid.TabIndex = 6;
            this.labelid.Text = " ID ";
            // 
            // labelsalary
            // 
            this.labelsalary.AutoSize = true;
            this.labelsalary.BackColor = System.Drawing.Color.Transparent;
            this.labelsalary.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsalary.ForeColor = System.Drawing.Color.White;
            this.labelsalary.Location = new System.Drawing.Point(43, 249);
            this.labelsalary.Name = "labelsalary";
            this.labelsalary.Size = new System.Drawing.Size(73, 36);
            this.labelsalary.TabIndex = 7;
            this.labelsalary.Text = "Salary";
            // 
            // labeltypeemp
            // 
            this.labeltypeemp.AutoSize = true;
            this.labeltypeemp.BackColor = System.Drawing.Color.Transparent;
            this.labeltypeemp.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltypeemp.ForeColor = System.Drawing.Color.White;
            this.labeltypeemp.Location = new System.Drawing.Point(25, 313);
            this.labeltypeemp.Name = "labeltypeemp";
            this.labeltypeemp.Size = new System.Drawing.Size(159, 36);
            this.labeltypeemp.TabIndex = 8;
            this.labeltypeemp.Text = "Type Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Employees is  :";
            // 
            // labelcountemp
            // 
            this.labelcountemp.AutoSize = true;
            this.labelcountemp.BackColor = System.Drawing.Color.Transparent;
            this.labelcountemp.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountemp.ForeColor = System.Drawing.Color.White;
            this.labelcountemp.Location = new System.Drawing.Point(519, 431);
            this.labelcountemp.Name = "labelcountemp";
            this.labelcountemp.Size = new System.Drawing.Size(34, 44);
            this.labelcountemp.TabIndex = 10;
            this.labelcountemp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sum of All Salariyes         :";
            // 
            // labelsumesal
            // 
            this.labelsumesal.AutoSize = true;
            this.labelsumesal.BackColor = System.Drawing.Color.Transparent;
            this.labelsumesal.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsumesal.ForeColor = System.Drawing.Color.White;
            this.labelsumesal.Location = new System.Drawing.Point(510, 505);
            this.labelsumesal.Name = "labelsumesal";
            this.labelsumesal.Size = new System.Drawing.Size(55, 44);
            this.labelsumesal.TabIndex = 12;
            this.labelsumesal.Text = "0.0";
            // 
            // LableTittle
            // 
            this.LableTittle.AutoSize = true;
            this.LableTittle.BackColor = System.Drawing.Color.Transparent;
            this.LableTittle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableTittle.ForeColor = System.Drawing.Color.White;
            this.LableTittle.Location = new System.Drawing.Point(238, 37);
            this.LableTittle.Name = "LableTittle";
            this.LableTittle.Size = new System.Drawing.Size(553, 43);
            this.LableTittle.TabIndex = 13;
            this.LableTittle.Text = "School  Emplooyess Salarys";
            this.LableTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LableTittle.Click += new System.EventHandler(this.LableTittle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(950, 590);
            this.Controls.Add(this.LableTittle);
            this.Controls.Add(this.labelsumesal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelcountemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltypeemp);
            this.Controls.Add(this.labelsalary);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.typeemployee);
            this.Controls.Add(this.textBoxsalary);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.btnADD);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxsalary;
        private System.Windows.Forms.ComboBox typeemployee;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelsalary;
        private System.Windows.Forms.Label labeltypeemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelcountemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelsumesal;
        private System.Windows.Forms.Label LableTittle;
    }
}

