namespace FinalProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDayStr = new System.Windows.Forms.Label();
            this.labelDayInt = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCalculator = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProfile = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonMinMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelClock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 1051);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FinalProject.Properties.Resources.calendar;
            this.panel2.Controls.Add(this.labelDayStr);
            this.panel2.Controls.Add(this.labelDayInt);
            this.panel2.Controls.Add(this.labelMonth);
            this.panel2.Location = new System.Drawing.Point(-1, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 481);
            this.panel2.TabIndex = 1;
            // 
            // labelDayStr
            // 
            this.labelDayStr.BackColor = System.Drawing.Color.Transparent;
            this.labelDayStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDayStr.Location = new System.Drawing.Point(0, 387);
            this.labelDayStr.Name = "labelDayStr";
            this.labelDayStr.Size = new System.Drawing.Size(423, 94);
            this.labelDayStr.TabIndex = 2;
            this.labelDayStr.Text = "Sunday";
            this.labelDayStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDayInt
            // 
            this.labelDayInt.BackColor = System.Drawing.Color.Transparent;
            this.labelDayInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDayInt.Location = new System.Drawing.Point(0, 293);
            this.labelDayInt.Name = "labelDayInt";
            this.labelDayInt.Size = new System.Drawing.Size(423, 94);
            this.labelDayInt.TabIndex = 1;
            this.labelDayInt.Text = "27";
            this.labelDayInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonth
            // 
            this.labelMonth.BackColor = System.Drawing.Color.Transparent;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMonth.Location = new System.Drawing.Point(3, 199);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(423, 94);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "June";
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClock
            // 
            this.labelClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelClock.Font = new System.Drawing.Font("Leelawadee UI", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.Color.White;
            this.labelClock.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelClock.Location = new System.Drawing.Point(-1, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(423, 124);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "12:33";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonAll,
            this.toolStripButtonSearch,
            this.toolStripButtonCalculator,
            this.toolStripButtonProfile,
            this.toolStripButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(423, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(869, 90);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.AutoSize = false;
            this.toolStripButtonAdd.Image = global::FinalProject.Properties.Resources._9133514_signup_register_login_icon;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(120, 85);
            this.toolStripButtonAdd.Text = "Add Data";
            this.toolStripButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonAll
            // 
            this.toolStripButtonAll.AutoSize = false;
            this.toolStripButtonAll.Image = global::FinalProject.Properties.Resources.show_data;
            this.toolStripButtonAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAll.Name = "toolStripButtonAll";
            this.toolStripButtonAll.Size = new System.Drawing.Size(120, 85);
            this.toolStripButtonAll.Text = "Show Data";
            this.toolStripButtonAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAll.Click += new System.EventHandler(this.toolStripButtonAll_Click);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.AutoSize = false;
            this.toolStripButtonSearch.Image = global::FinalProject.Properties.Resources._172546_search_icon;
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(120, 85);
            this.toolStripButtonSearch.Text = "Search Data";
            this.toolStripButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // toolStripButtonCalculator
            // 
            this.toolStripButtonCalculator.AutoSize = false;
            this.toolStripButtonCalculator.Image = global::FinalProject.Properties.Resources._1291736_algebra_calculator_math_mathmematics_icon;
            this.toolStripButtonCalculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalculator.Name = "toolStripButtonCalculator";
            this.toolStripButtonCalculator.Size = new System.Drawing.Size(120, 85);
            this.toolStripButtonCalculator.Text = "Calculator";
            this.toolStripButtonCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCalculator.Click += new System.EventHandler(this.toolStripButtonCalculator_Click);
            // 
            // toolStripButtonProfile
            // 
            this.toolStripButtonProfile.AutoSize = false;
            this.toolStripButtonProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.toolStripButtonProfile.Image = global::FinalProject.Properties.Resources._4092564_profile_about_mobile_ui_user_icon;
            this.toolStripButtonProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProfile.Name = "toolStripButtonProfile";
            this.toolStripButtonProfile.Size = new System.Drawing.Size(120, 85);
            this.toolStripButtonProfile.Text = "Profile";
            this.toolStripButtonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.usersToolStripMenuItem.Text = "User";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.AutoSize = false;
            this.toolStripButtonAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.toolStripButtonAbout.Image = global::FinalProject.Properties.Resources._2931180_about_info_information_chat_service_icon;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(120, 85);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonMinMax
            // 
            this.buttonMinMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinMax.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.buttonMinMax.Image = global::FinalProject.Properties.Resources.minimize__2_;
            this.buttonMinMax.Location = new System.Drawing.Point(1106, 12);
            this.buttonMinMax.Name = "buttonMinMax";
            this.buttonMinMax.Size = new System.Drawing.Size(50, 50);
            this.buttonMinMax.TabIndex = 3;
            this.buttonMinMax.UseVisualStyleBackColor = true;
            this.buttonMinMax.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Image = global::FinalProject.Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            this.buttonClose.Location = new System.Drawing.Point(1184, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 1051);
            this.Controls.Add(this.buttonMinMax);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalculator;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonProfile;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button buttonMinMax;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDayStr;
        private System.Windows.Forms.Label labelDayInt;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAll;
    }
}

