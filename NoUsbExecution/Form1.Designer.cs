namespace NoUsbExecution
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
            this.fullaccessbtn = new System.Windows.Forms.Button();
            this.readonlybtn = new System.Windows.Forms.Button();
            this.disabledbtn = new System.Windows.Forms.Button();
            this.applybtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullaccessbtn
            // 
            this.fullaccessbtn.Location = new System.Drawing.Point(38, 65);
            this.fullaccessbtn.Margin = new System.Windows.Forms.Padding(2);
            this.fullaccessbtn.Name = "fullaccessbtn";
            this.fullaccessbtn.Size = new System.Drawing.Size(82, 41);
            this.fullaccessbtn.TabIndex = 0;
            this.fullaccessbtn.Text = "Full Access";
            this.fullaccessbtn.UseVisualStyleBackColor = true;
            this.fullaccessbtn.Click += new System.EventHandler(this.fullaccessbtn_Click);
            // 
            // readonlybtn
            // 
            this.readonlybtn.Location = new System.Drawing.Point(154, 65);
            this.readonlybtn.Margin = new System.Windows.Forms.Padding(2);
            this.readonlybtn.Name = "readonlybtn";
            this.readonlybtn.Size = new System.Drawing.Size(82, 41);
            this.readonlybtn.TabIndex = 1;
            this.readonlybtn.Text = "Read Only";
            this.readonlybtn.UseVisualStyleBackColor = true;
            this.readonlybtn.Click += new System.EventHandler(this.readonlybtn_Click);
            // 
            // disabledbtn
            // 
            this.disabledbtn.Location = new System.Drawing.Point(268, 65);
            this.disabledbtn.Margin = new System.Windows.Forms.Padding(2);
            this.disabledbtn.Name = "disabledbtn";
            this.disabledbtn.Size = new System.Drawing.Size(82, 41);
            this.disabledbtn.TabIndex = 2;
            this.disabledbtn.Text = "Disabled";
            this.disabledbtn.UseVisualStyleBackColor = true;
            this.disabledbtn.Click += new System.EventHandler(this.disabledbtn_Click);
            // 
            // applybtn
            // 
            this.applybtn.Location = new System.Drawing.Point(154, 215);
            this.applybtn.Margin = new System.Windows.Forms.Padding(2);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(62, 24);
            this.applybtn.TabIndex = 3;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = true;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(234, 215);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(62, 24);
            this.refreshbtn.TabIndex = 4;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(317, 215);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(62, 24);
            this.closebtn.TabIndex = 5;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 263);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.applybtn);
            this.Controls.Add(this.disabledbtn);
            this.Controls.Add(this.readonlybtn);
            this.Controls.Add(this.fullaccessbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fullaccessbtn;
        private System.Windows.Forms.Button readonlybtn;
        private System.Windows.Forms.Button disabledbtn;
        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button closebtn;
    }
}

