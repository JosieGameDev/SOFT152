namespace CourseWork
{
    partial class frmHomepage
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
            this.lstMonth = new System.Windows.Forms.ListBox();
            this.lstYear = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.btnAddMonth = new System.Windows.Forms.Button();
            this.btnReadIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMonth
            // 
            this.lstMonth.FormattingEnabled = true;
            this.lstMonth.ItemHeight = 16;
            this.lstMonth.Location = new System.Drawing.Point(326, 269);
            this.lstMonth.Name = "lstMonth";
            this.lstMonth.Size = new System.Drawing.Size(616, 180);
            this.lstMonth.TabIndex = 11;
            // 
            // lstYear
            // 
            this.lstYear.FormattingEnabled = true;
            this.lstYear.ItemHeight = 16;
            this.lstYear.Location = new System.Drawing.Point(326, 120);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(616, 116);
            this.lstYear.TabIndex = 10;
            this.lstYear.SelectedIndexChanged += new System.EventHandler(this.lstYear_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowData);
            this.groupBox1.Controls.Add(this.btnEditYear);
            this.groupBox1.Controls.Add(this.btnAddYear);
            this.groupBox1.Controls.Add(this.btnEditMonth);
            this.groupBox1.Controls.Add(this.btnAddMonth);
            this.groupBox1.Controls.Add(this.btnReadIn);
            this.groupBox1.Location = new System.Drawing.Point(28, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 312);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Features";
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(42, 247);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(146, 23);
            this.btnShowData.TabIndex = 12;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Location = new System.Drawing.Point(42, 207);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(146, 23);
            this.btnEditYear.TabIndex = 11;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            this.btnEditYear.Click += new System.EventHandler(this.btnEditYear_Click);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Location = new System.Drawing.Point(42, 167);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(146, 23);
            this.btnAddYear.TabIndex = 10;
            this.btnAddYear.Text = "Add Year";
            this.btnAddYear.UseVisualStyleBackColor = true;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Location = new System.Drawing.Point(42, 127);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(146, 23);
            this.btnEditMonth.TabIndex = 9;
            this.btnEditMonth.Text = "Edit Month";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            this.btnEditMonth.Click += new System.EventHandler(this.btnEditMonth_Click);
            // 
            // btnAddMonth
            // 
            this.btnAddMonth.Location = new System.Drawing.Point(42, 87);
            this.btnAddMonth.Name = "btnAddMonth";
            this.btnAddMonth.Size = new System.Drawing.Size(146, 23);
            this.btnAddMonth.TabIndex = 8;
            this.btnAddMonth.Text = "Add Month";
            this.btnAddMonth.UseVisualStyleBackColor = true;
            this.btnAddMonth.Click += new System.EventHandler(this.btnAddMonth_Click);
            // 
            // btnReadIn
            // 
            this.btnReadIn.Location = new System.Drawing.Point(42, 47);
            this.btnReadIn.Name = "btnReadIn";
            this.btnReadIn.Size = new System.Drawing.Size(146, 23);
            this.btnReadIn.TabIndex = 7;
            this.btnReadIn.Text = "Read in Data";
            this.btnReadIn.UseVisualStyleBackColor = true;
            this.btnReadIn.Click += new System.EventHandler(this.btnReadIn_Click);
            // 
            // frmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 534);
            this.Controls.Add(this.lstMonth);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHomepage";
            this.Text = "frmHomepage";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMonth;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.Button btnAddMonth;
        private System.Windows.Forms.Button btnReadIn;
    }
}