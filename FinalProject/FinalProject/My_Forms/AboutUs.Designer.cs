namespace FinalProject.My_Forms
{
    partial class AboutUs
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
            this.labelComanyName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersionname = new System.Windows.Forms.Label();
            this.labelWebSite = new System.Windows.Forms.Label();
            this.labelProgramer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelComanyName
            // 
            this.labelComanyName.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComanyName.Location = new System.Drawing.Point(191, 54);
            this.labelComanyName.Name = "labelComanyName";
            this.labelComanyName.Size = new System.Drawing.Size(500, 50);
            this.labelComanyName.TabIndex = 0;
            this.labelComanyName.Text = "Rax Rot Company";
            this.labelComanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            this.labelProductName.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(191, 137);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(500, 50);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "label1";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersionname
            // 
            this.labelVersionname.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersionname.Location = new System.Drawing.Point(191, 230);
            this.labelVersionname.Name = "labelVersionname";
            this.labelVersionname.Size = new System.Drawing.Size(500, 50);
            this.labelVersionname.TabIndex = 2;
            this.labelVersionname.Text = "label1";
            this.labelVersionname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWebSite
            // 
            this.labelWebSite.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebSite.Location = new System.Drawing.Point(191, 321);
            this.labelWebSite.Name = "labelWebSite";
            this.labelWebSite.Size = new System.Drawing.Size(500, 50);
            this.labelWebSite.TabIndex = 3;
            this.labelWebSite.Text = "label1";
            this.labelWebSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProgramer
            // 
            this.labelProgramer.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramer.Location = new System.Drawing.Point(191, 414);
            this.labelProgramer.Name = "labelProgramer";
            this.labelProgramer.Size = new System.Drawing.Size(500, 50);
            this.labelProgramer.TabIndex = 4;
            this.labelProgramer.Text = "label1";
            this.labelProgramer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 619);
            this.Controls.Add(this.labelProgramer);
            this.Controls.Add(this.labelWebSite);
            this.Controls.Add(this.labelVersionname);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelComanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutUs";
            this.Load += new System.EventHandler(this.AboutUs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelComanyName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersionname;
        private System.Windows.Forms.Label labelWebSite;
        private System.Windows.Forms.Label labelProgramer;
    }
}