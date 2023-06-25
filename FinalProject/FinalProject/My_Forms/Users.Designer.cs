namespace FinalProject.My_Forms
{
    partial class Users
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.labelPasword = new System.Windows.Forms.Label();
            this.textBoxConfirmPasword = new System.Windows.Forms.TextBox();
            this.labelConfPasword = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserName.Location = new System.Drawing.Point(115, 116);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(129, 26);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(271, 118);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(334, 26);
            this.textBoxUserName.TabIndex = 3;
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(271, 179);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(334, 26);
            this.textBoxPasword.TabIndex = 5;
            this.textBoxPasword.UseSystemPasswordChar = true;
            // 
            // labelPasword
            // 
            this.labelPasword.AutoSize = true;
            this.labelPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasword.Location = new System.Drawing.Point(130, 177);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(114, 26);
            this.labelPasword.TabIndex = 4;
            this.labelPasword.Text = "Password:";
            // 
            // textBoxConfirmPasword
            // 
            this.textBoxConfirmPasword.Location = new System.Drawing.Point(271, 234);
            this.textBoxConfirmPasword.Name = "textBoxConfirmPasword";
            this.textBoxConfirmPasword.Size = new System.Drawing.Size(334, 26);
            this.textBoxConfirmPasword.TabIndex = 7;
            this.textBoxConfirmPasword.UseSystemPasswordChar = true;
            // 
            // labelConfPasword
            // 
            this.labelConfPasword.AutoSize = true;
            this.labelConfPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConfPasword.Location = new System.Drawing.Point(58, 234);
            this.labelConfPasword.Name = "labelConfPasword";
            this.labelConfPasword.Size = new System.Drawing.Size(186, 26);
            this.labelConfPasword.TabIndex = 6;
            this.labelConfPasword.Text = "Confirm Pasword:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Jpg Files|";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSaveChanges.Image = global::FinalProject.Properties.Resources.save;
            this.buttonSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveChanges.Location = new System.Drawing.Point(306, 285);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(239, 88);
            this.buttonSaveChanges.TabIndex = 8;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 526);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.textBoxConfirmPasword);
            this.Controls.Add(this.labelConfPasword);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.labelPasword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.TextBox textBoxConfirmPasword;
        private System.Windows.Forms.Label labelConfPasword;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}