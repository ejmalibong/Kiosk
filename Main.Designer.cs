
namespace Kiosk
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelHandbook = new System.Windows.Forms.Panel();
            this.lblHandbook = new System.Windows.Forms.Label();
            this.panelLeaveApp = new System.Windows.Forms.Panel();
            this.lblLeaveApp = new System.Windows.Forms.Label();
            this.panelDtr = new System.Windows.Forms.Panel();
            this.lblDtr = new System.Windows.Forms.Label();
            this.panelLoadBalance = new System.Windows.Forms.Panel();
            this.lblLoadBalance = new System.Windows.Forms.Label();
            this.panelOrderingSystem = new System.Windows.Forms.Panel();
            this.lblOrderingSystem = new System.Windows.Forms.Label();
            this.panelGovs = new System.Windows.Forms.Panel();
            this.picPagibig = new System.Windows.Forms.PictureBox();
            this.picSss = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelHandbook.SuspendLayout();
            this.panelLeaveApp.SuspendLayout();
            this.panelDtr.SuspendLayout();
            this.panelLoadBalance.SuspendLayout();
            this.panelOrderingSystem.SuspendLayout();
            this.panelGovs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPagibig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSss)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lblLogo);
            this.panel.Controls.Add(this.lblTime);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.lblDate);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1336, 80);
            this.panel.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Arial", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLogo.Location = new System.Drawing.Point(160, 13);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(1015, 53);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "NBC (Philippines) Car Technology Corporation";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(1195, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "1:40 PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Kiosk.Properties.Resources.nbc;
            this.pictureBox.Location = new System.Drawing.Point(12, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(1152, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(175, 29);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Apr 2, 2025";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelHandbook
            // 
            this.panelHandbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHandbook.Controls.Add(this.lblHandbook);
            this.panelHandbook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandbook.Location = new System.Drawing.Point(0, 80);
            this.panelHandbook.Name = "panelHandbook";
            this.panelHandbook.Size = new System.Drawing.Size(1336, 105);
            this.panelHandbook.TabIndex = 2;
            this.panelHandbook.Click += new System.EventHandler(this.panelHandbook_Click);
            // 
            // lblHandbook
            // 
            this.lblHandbook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHandbook.AutoSize = true;
            this.lblHandbook.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.lblHandbook.Location = new System.Drawing.Point(317, 11);
            this.lblHandbook.Name = "lblHandbook";
            this.lblHandbook.Size = new System.Drawing.Size(700, 78);
            this.lblHandbook.TabIndex = 1;
            this.lblHandbook.Text = "Employee HandBook";
            this.lblHandbook.Click += new System.EventHandler(this.lblHandbook_Click);
            // 
            // panelLeaveApp
            // 
            this.panelLeaveApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeaveApp.Controls.Add(this.lblLeaveApp);
            this.panelLeaveApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeaveApp.Location = new System.Drawing.Point(0, 185);
            this.panelLeaveApp.Name = "panelLeaveApp";
            this.panelLeaveApp.Size = new System.Drawing.Size(1336, 105);
            this.panelLeaveApp.TabIndex = 3;
            this.panelLeaveApp.Click += new System.EventHandler(this.panelLeaveApp_Click);
            // 
            // lblLeaveApp
            // 
            this.lblLeaveApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLeaveApp.AutoSize = true;
            this.lblLeaveApp.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveApp.Location = new System.Drawing.Point(240, 11);
            this.lblLeaveApp.Name = "lblLeaveApp";
            this.lblLeaveApp.Size = new System.Drawing.Size(855, 78);
            this.lblLeaveApp.TabIndex = 1;
            this.lblLeaveApp.Text = "Leave Application System";
            this.lblLeaveApp.Click += new System.EventHandler(this.lblLeaveApp_Click);
            // 
            // panelDtr
            // 
            this.panelDtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDtr.Controls.Add(this.lblDtr);
            this.panelDtr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDtr.Location = new System.Drawing.Point(0, 290);
            this.panelDtr.Name = "panelDtr";
            this.panelDtr.Size = new System.Drawing.Size(1336, 105);
            this.panelDtr.TabIndex = 4;
            this.panelDtr.Click += new System.EventHandler(this.panelDtr_Click);
            // 
            // lblDtr
            // 
            this.lblDtr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDtr.AutoSize = true;
            this.lblDtr.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.lblDtr.Location = new System.Drawing.Point(243, 10);
            this.lblDtr.Name = "lblDtr";
            this.lblDtr.Size = new System.Drawing.Size(848, 78);
            this.lblDtr.TabIndex = 2;
            this.lblDtr.Text = "Daily Time Record Viewer";
            this.lblDtr.Click += new System.EventHandler(this.lblDtr_Click);
            // 
            // panelLoadBalance
            // 
            this.panelLoadBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoadBalance.Controls.Add(this.lblLoadBalance);
            this.panelLoadBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoadBalance.Location = new System.Drawing.Point(0, 395);
            this.panelLoadBalance.Name = "panelLoadBalance";
            this.panelLoadBalance.Size = new System.Drawing.Size(1336, 105);
            this.panelLoadBalance.TabIndex = 5;
            this.panelLoadBalance.Click += new System.EventHandler(this.panelLoadBalance_Click);
            // 
            // lblLoadBalance
            // 
            this.lblLoadBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoadBalance.AutoSize = true;
            this.lblLoadBalance.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.lblLoadBalance.Location = new System.Drawing.Point(223, 10);
            this.lblLoadBalance.Name = "lblLoadBalance";
            this.lblLoadBalance.Size = new System.Drawing.Size(888, 78);
            this.lblLoadBalance.TabIndex = 3;
            this.lblLoadBalance.Text = "Canteen Purchases Viewer";
            this.lblLoadBalance.Click += new System.EventHandler(this.lblLoadBalance_Click);
            // 
            // panelOrderingSystem
            // 
            this.panelOrderingSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrderingSystem.Controls.Add(this.lblOrderingSystem);
            this.panelOrderingSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderingSystem.Location = new System.Drawing.Point(0, 500);
            this.panelOrderingSystem.Name = "panelOrderingSystem";
            this.panelOrderingSystem.Size = new System.Drawing.Size(1336, 105);
            this.panelOrderingSystem.TabIndex = 6;
            // 
            // lblOrderingSystem
            // 
            this.lblOrderingSystem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOrderingSystem.AutoSize = true;
            this.lblOrderingSystem.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.lblOrderingSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrderingSystem.Location = new System.Drawing.Point(382, 12);
            this.lblOrderingSystem.Name = "lblOrderingSystem";
            this.lblOrderingSystem.Size = new System.Drawing.Size(570, 78);
            this.lblOrderingSystem.TabIndex = 5;
            this.lblOrderingSystem.Text = "Ordering System";
            // 
            // panelGovs
            // 
            this.panelGovs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGovs.Controls.Add(this.picPagibig);
            this.panelGovs.Controls.Add(this.picSss);
            this.panelGovs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGovs.Location = new System.Drawing.Point(0, 605);
            this.panelGovs.Name = "panelGovs";
            this.panelGovs.Size = new System.Drawing.Size(1336, 105);
            this.panelGovs.TabIndex = 7;
            // 
            // picPagibig
            // 
            this.picPagibig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picPagibig.ErrorImage = global::Kiosk.Properties.Resources.pag_ibig;
            this.picPagibig.Image = global::Kiosk.Properties.Resources.pag_ibig;
            this.picPagibig.InitialImage = global::Kiosk.Properties.Resources.pag_ibig;
            this.picPagibig.Location = new System.Drawing.Point(816, 1);
            this.picPagibig.Name = "picPagibig";
            this.picPagibig.Size = new System.Drawing.Size(150, 96);
            this.picPagibig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPagibig.TabIndex = 5;
            this.picPagibig.TabStop = false;
            this.picPagibig.Click += new System.EventHandler(this.picPagibig_Click);
            // 
            // picSss
            // 
            this.picSss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSss.ErrorImage = global::Kiosk.Properties.Resources.sss;
            this.picSss.Image = global::Kiosk.Properties.Resources.sss;
            this.picSss.InitialImage = global::Kiosk.Properties.Resources.sss;
            this.picSss.Location = new System.Drawing.Point(403, 1);
            this.picSss.Name = "picSss";
            this.picSss.Size = new System.Drawing.Size(180, 96);
            this.picSss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSss.TabIndex = 4;
            this.picSss.TabStop = false;
            this.picSss.Click += new System.EventHandler(this.picSss_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 716);
            this.Controls.Add(this.panelGovs);
            this.Controls.Add(this.panelOrderingSystem);
            this.Controls.Add(this.panelLoadBalance);
            this.Controls.Add(this.panelDtr);
            this.Controls.Add(this.panelLeaveApp);
            this.Controls.Add(this.panelHandbook);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelHandbook.ResumeLayout(false);
            this.panelHandbook.PerformLayout();
            this.panelLeaveApp.ResumeLayout(false);
            this.panelLeaveApp.PerformLayout();
            this.panelDtr.ResumeLayout(false);
            this.panelDtr.PerformLayout();
            this.panelLoadBalance.ResumeLayout(false);
            this.panelLoadBalance.PerformLayout();
            this.panelOrderingSystem.ResumeLayout(false);
            this.panelOrderingSystem.PerformLayout();
            this.panelGovs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPagibig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelHandbook;
        private System.Windows.Forms.Panel panelLeaveApp;
        private System.Windows.Forms.Label lblLeaveApp;
        private System.Windows.Forms.Label lblHandbook;
        private System.Windows.Forms.Panel panelDtr;
        private System.Windows.Forms.Label lblDtr;
        private System.Windows.Forms.Panel panelLoadBalance;
        private System.Windows.Forms.Panel panelOrderingSystem;
        private System.Windows.Forms.Panel panelGovs;
        private System.Windows.Forms.PictureBox picPagibig;
        private System.Windows.Forms.PictureBox picSss;
        private System.Windows.Forms.Label lblLoadBalance;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblOrderingSystem;
    }
}

