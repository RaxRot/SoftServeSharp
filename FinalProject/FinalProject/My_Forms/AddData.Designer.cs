namespace FinalProject.My_Forms
{
    partial class AddData
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveData = new System.Windows.Forms.ToolStripButton();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddData,
            this.toolStripSeparator1,
            this.toolStripButtonSaveData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(918, 86);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddData
            // 
            this.toolStripButtonAddData.AutoSize = false;
            this.toolStripButtonAddData.Image = global::FinalProject.Properties.Resources._9133514_signup_register_login_icon;
            this.toolStripButtonAddData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddData.Name = "toolStripButtonAddData";
            this.toolStripButtonAddData.Size = new System.Drawing.Size(180, 60);
            this.toolStripButtonAddData.Text = "New Data";
            this.toolStripButtonAddData.Click += new System.EventHandler(this.toolStripButtonAddData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // toolStripButtonSaveData
            // 
            this.toolStripButtonSaveData.AutoSize = false;
            this.toolStripButtonSaveData.Enabled = false;
            this.toolStripButtonSaveData.Image = global::FinalProject.Properties.Resources.save;
            this.toolStripButtonSaveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveData.Name = "toolStripButtonSaveData";
            this.toolStripButtonSaveData.Size = new System.Drawing.Size(180, 60);
            this.toolStripButtonSaveData.Text = "Save Changes";
            this.toolStripButtonSaveData.Click += new System.EventHandler(this.toolStripButtonSaveData_Click);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.textBoxEmail);
            this.groupBoxInformation.Controls.Add(this.labelEmail);
            this.groupBoxInformation.Controls.Add(this.textBoxTel);
            this.groupBoxInformation.Controls.Add(this.labelTel);
            this.groupBoxInformation.Controls.Add(this.textBoxLastName);
            this.groupBoxInformation.Controls.Add(this.labelLastName);
            this.groupBoxInformation.Controls.Add(this.textBoxFirstName);
            this.groupBoxInformation.Controls.Add(this.labelFirstName);
            this.groupBoxInformation.Location = new System.Drawing.Point(169, 179);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(566, 581);
            this.groupBoxInformation.TabIndex = 1;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(175, 175);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(291, 26);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(25, 175);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(144, 31);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(175, 250);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(291, 26);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(25, 250);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(141, 31);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(175, 325);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(291, 26);
            this.textBoxTel.TabIndex = 7;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTel.Location = new System.Drawing.Point(103, 319);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(54, 31);
            this.labelTel.TabIndex = 6;
            this.labelTel.Text = "Tel:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(175, 400);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(291, 26);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(67, 400);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 31);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 866);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddData";
            this.Load += new System.EventHandler(this.AddData_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddData;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
    }
}