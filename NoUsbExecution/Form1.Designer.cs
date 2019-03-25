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
            this.fullaccessbtn.Location = new System.Drawing.Point(51, 80);
            this.fullaccessbtn.Name = "fullaccessbtn";
            this.fullaccessbtn.Size = new System.Drawing.Size(109, 50);
            this.fullaccessbtn.TabIndex = 0;
            this.fullaccessbtn.Text = "Full Access";
            this.fullaccessbtn.UseVisualStyleBackColor = true;
            // 
            // readonlybtn
            // 
            this.readonlybtn.Location = new System.Drawing.Point(205, 80);
            this.readonlybtn.Name = "readonlybtn";
            this.readonlybtn.Size = new System.Drawing.Size(109, 50);
            this.readonlybtn.TabIndex = 1;
            this.readonlybtn.Text = "Read Only";
            this.readonlybtn.UseVisualStyleBackColor = true;
            // 
            // disabledbtn
            // 
            this.disabledbtn.Location = new System.Drawing.Point(357, 80);
            this.disabledbtn.Name = "disabledbtn";
            this.disabledbtn.Size = new System.Drawing.Size(109, 50);
            this.disabledbtn.TabIndex = 2;
            this.disabledbtn.Text = "Disabled";
            this.disabledbtn.UseVisualStyleBackColor = true;
            // 
            // applybtn
            // 
            this.applybtn.Location = new System.Drawing.Point(205, 265);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(83, 29);
            this.applybtn.TabIndex = 3;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = true;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(312, 265);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(83, 29);
            this.refreshbtn.TabIndex = 4;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(423, 265);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(83, 29);
            this.closebtn.TabIndex = 5;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 324);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.applybtn);
            this.Controls.Add(this.disabledbtn);
            this.Controls.Add(this.readonlybtn);
            this.Controls.Add(this.fullaccessbtn);
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

