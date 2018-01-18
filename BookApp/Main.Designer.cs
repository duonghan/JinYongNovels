namespace BookApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblHomeHelp = new System.Windows.Forms.Label();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnSideSearch = new System.Windows.Forms.Button();
            this.btnSideList = new System.Windows.Forms.Button();
            this.btnSideHome = new System.Windows.Forms.Button();
            this.btnHomeHelp = new System.Windows.Forms.Button();
            this.pnlHomeTop = new System.Windows.Forms.Panel();
            this.pnlHomeLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.btnHomeFB = new System.Windows.Forms.Button();
            this.btnHomeTwitter = new System.Windows.Forms.Button();
            this.btnHomeGithub = new System.Windows.Forms.Button();
            this.btnHomeNoti = new System.Windows.Forms.Button();
            this.btnHomeSetting = new System.Windows.Forms.Button();
            this.btnHomeExit = new System.Windows.Forms.Button();
            this.btnHomeSlack = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlHomeLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSidebar.Controls.Add(this.lblHomeHelp);
            this.pnlSidebar.Controls.Add(this.btnAuthor);
            this.pnlSidebar.Controls.Add(this.btnSideSearch);
            this.pnlSidebar.Controls.Add(this.btnSideList);
            this.pnlSidebar.Controls.Add(this.btnSideHome);
            this.pnlSidebar.Controls.Add(this.btnHomeHelp);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(211, 515);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblHomeHelp
            // 
            this.lblHomeHelp.AutoSize = true;
            this.lblHomeHelp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeHelp.ForeColor = System.Drawing.Color.White;
            this.lblHomeHelp.Location = new System.Drawing.Point(53, 486);
            this.lblHomeHelp.Name = "lblHomeHelp";
            this.lblHomeHelp.Size = new System.Drawing.Size(81, 17);
            this.lblHomeHelp.TabIndex = 3;
            this.lblHomeHelp.Text = "version 1.0.0";
            // 
            // btnAuthor
            // 
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAuthor.Image = global::BookApp.Properties.Resources.Account_32px;
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.Location = new System.Drawing.Point(9, 299);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(196, 51);
            this.btnAuthor.TabIndex = 4;
            this.btnAuthor.Text = "           Thông tin tác giả";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnSideSearch
            // 
            this.btnSideSearch.FlatAppearance.BorderSize = 0;
            this.btnSideSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideSearch.ForeColor = System.Drawing.Color.White;
            this.btnSideSearch.Image = global::BookApp.Properties.Resources.Search_32px;
            this.btnSideSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideSearch.Location = new System.Drawing.Point(9, 242);
            this.btnSideSearch.Name = "btnSideSearch";
            this.btnSideSearch.Size = new System.Drawing.Size(196, 51);
            this.btnSideSearch.TabIndex = 4;
            this.btnSideSearch.Text = "           Tìm kiếm";
            this.btnSideSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideSearch.UseVisualStyleBackColor = true;
            this.btnSideSearch.Click += new System.EventHandler(this.btnSideSearch_Click);
            // 
            // btnSideList
            // 
            this.btnSideList.FlatAppearance.BorderSize = 0;
            this.btnSideList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideList.ForeColor = System.Drawing.Color.White;
            this.btnSideList.Image = global::BookApp.Properties.Resources.Literature_32px;
            this.btnSideList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideList.Location = new System.Drawing.Point(9, 185);
            this.btnSideList.Name = "btnSideList";
            this.btnSideList.Size = new System.Drawing.Size(196, 51);
            this.btnSideList.TabIndex = 4;
            this.btnSideList.Text = "           Danh sách truyện";
            this.btnSideList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideList.UseVisualStyleBackColor = true;
            this.btnSideList.Click += new System.EventHandler(this.btnSideList_Click);
            // 
            // btnSideHome
            // 
            this.btnSideHome.FlatAppearance.BorderSize = 0;
            this.btnSideHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideHome.ForeColor = System.Drawing.Color.White;
            this.btnSideHome.Image = global::BookApp.Properties.Resources.Home_32px;
            this.btnSideHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideHome.Location = new System.Drawing.Point(9, 128);
            this.btnSideHome.Name = "btnSideHome";
            this.btnSideHome.Size = new System.Drawing.Size(196, 51);
            this.btnSideHome.TabIndex = 4;
            this.btnSideHome.Text = "           Trang chủ";
            this.btnSideHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideHome.UseVisualStyleBackColor = true;
            this.btnSideHome.Click += new System.EventHandler(this.btnSideHome_Click);
            // 
            // btnHomeHelp
            // 
            this.btnHomeHelp.FlatAppearance.BorderSize = 0;
            this.btnHomeHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeHelp.ForeColor = System.Drawing.Color.White;
            this.btnHomeHelp.Image = global::BookApp.Properties.Resources.Help_32px;
            this.btnHomeHelp.Location = new System.Drawing.Point(12, 477);
            this.btnHomeHelp.Name = "btnHomeHelp";
            this.btnHomeHelp.Size = new System.Drawing.Size(35, 35);
            this.btnHomeHelp.TabIndex = 4;
            this.btnHomeHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeHelp.UseVisualStyleBackColor = true;
            // 
            // pnlHomeTop
            // 
            this.pnlHomeTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlHomeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomeTop.Location = new System.Drawing.Point(211, 0);
            this.pnlHomeTop.Name = "pnlHomeTop";
            this.pnlHomeTop.Size = new System.Drawing.Size(813, 10);
            this.pnlHomeTop.TabIndex = 1;
            // 
            // pnlHomeLogo
            // 
            this.pnlHomeLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlHomeLogo.Controls.Add(this.label1);
            this.pnlHomeLogo.Controls.Add(this.pictureBox1);
            this.pnlHomeLogo.Location = new System.Drawing.Point(255, 0);
            this.pnlHomeLogo.Name = "pnlHomeLogo";
            this.pnlHomeLogo.Size = new System.Drawing.Size(111, 124);
            this.pnlHomeLogo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 65);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlSide.Location = new System.Drawing.Point(0, 128);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(8, 51);
            this.pnlSide.TabIndex = 4;
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.Location = new System.Drawing.Point(372, 13);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(412, 30);
            this.lblHomeTitle.TabIndex = 6;
            this.lblHomeTitle.Text = "Phần mềm đọc truyện kiếm hiệp Kim Dung";
            // 
            // btnHomeFB
            // 
            this.btnHomeFB.FlatAppearance.BorderSize = 0;
            this.btnHomeFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeFB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeFB.ForeColor = System.Drawing.Color.White;
            this.btnHomeFB.Image = global::BookApp.Properties.Resources.Facebook_32px;
            this.btnHomeFB.Location = new System.Drawing.Point(657, 63);
            this.btnHomeFB.Name = "btnHomeFB";
            this.btnHomeFB.Size = new System.Drawing.Size(35, 35);
            this.btnHomeFB.TabIndex = 4;
            this.btnHomeFB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeFB.UseVisualStyleBackColor = true;
            // 
            // btnHomeTwitter
            // 
            this.btnHomeTwitter.FlatAppearance.BorderSize = 0;
            this.btnHomeTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeTwitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeTwitter.ForeColor = System.Drawing.Color.White;
            this.btnHomeTwitter.Image = global::BookApp.Properties.Resources.Twitter_32px;
            this.btnHomeTwitter.Location = new System.Drawing.Point(698, 63);
            this.btnHomeTwitter.Name = "btnHomeTwitter";
            this.btnHomeTwitter.Size = new System.Drawing.Size(35, 35);
            this.btnHomeTwitter.TabIndex = 4;
            this.btnHomeTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeTwitter.UseVisualStyleBackColor = true;
            // 
            // btnHomeGithub
            // 
            this.btnHomeGithub.FlatAppearance.BorderSize = 0;
            this.btnHomeGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeGithub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeGithub.ForeColor = System.Drawing.Color.White;
            this.btnHomeGithub.Image = global::BookApp.Properties.Resources.GitHub_32px;
            this.btnHomeGithub.Location = new System.Drawing.Point(739, 63);
            this.btnHomeGithub.Name = "btnHomeGithub";
            this.btnHomeGithub.Size = new System.Drawing.Size(35, 35);
            this.btnHomeGithub.TabIndex = 4;
            this.btnHomeGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeGithub.UseVisualStyleBackColor = true;
            // 
            // btnHomeNoti
            // 
            this.btnHomeNoti.FlatAppearance.BorderSize = 0;
            this.btnHomeNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeNoti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeNoti.ForeColor = System.Drawing.Color.White;
            this.btnHomeNoti.Image = global::BookApp.Properties.Resources.Notification_32px;
            this.btnHomeNoti.Location = new System.Drawing.Point(889, 16);
            this.btnHomeNoti.Name = "btnHomeNoti";
            this.btnHomeNoti.Size = new System.Drawing.Size(35, 35);
            this.btnHomeNoti.TabIndex = 4;
            this.btnHomeNoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeNoti.UseVisualStyleBackColor = true;
            // 
            // btnHomeSetting
            // 
            this.btnHomeSetting.FlatAppearance.BorderSize = 0;
            this.btnHomeSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeSetting.ForeColor = System.Drawing.Color.White;
            this.btnHomeSetting.Image = global::BookApp.Properties.Resources.Settings_32px;
            this.btnHomeSetting.Location = new System.Drawing.Point(930, 16);
            this.btnHomeSetting.Name = "btnHomeSetting";
            this.btnHomeSetting.Size = new System.Drawing.Size(35, 35);
            this.btnHomeSetting.TabIndex = 4;
            this.btnHomeSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeSetting.UseVisualStyleBackColor = true;
            // 
            // btnHomeExit
            // 
            this.btnHomeExit.FlatAppearance.BorderSize = 0;
            this.btnHomeExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeExit.ForeColor = System.Drawing.Color.White;
            this.btnHomeExit.Image = global::BookApp.Properties.Resources.Shutdown_32px;
            this.btnHomeExit.Location = new System.Drawing.Point(971, 16);
            this.btnHomeExit.Name = "btnHomeExit";
            this.btnHomeExit.Size = new System.Drawing.Size(35, 35);
            this.btnHomeExit.TabIndex = 4;
            this.btnHomeExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeExit.UseVisualStyleBackColor = true;
            // 
            // btnHomeSlack
            // 
            this.btnHomeSlack.FlatAppearance.BorderSize = 0;
            this.btnHomeSlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeSlack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeSlack.ForeColor = System.Drawing.Color.White;
            this.btnHomeSlack.Image = global::BookApp.Properties.Resources.Slack_32px;
            this.btnHomeSlack.Location = new System.Drawing.Point(616, 63);
            this.btnHomeSlack.Name = "btnHomeSlack";
            this.btnHomeSlack.Size = new System.Drawing.Size(35, 35);
            this.btnHomeSlack.TabIndex = 4;
            this.btnHomeSlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeSlack.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 515);
            this.Controls.Add(this.lblHomeTitle);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.btnHomeExit);
            this.Controls.Add(this.btnHomeSetting);
            this.Controls.Add(this.btnHomeGithub);
            this.Controls.Add(this.btnHomeNoti);
            this.Controls.Add(this.btnHomeTwitter);
            this.Controls.Add(this.btnHomeSlack);
            this.Controls.Add(this.btnHomeFB);
            this.Controls.Add(this.pnlHomeLogo);
            this.Controls.Add(this.pnlHomeTop);
            this.Controls.Add(this.pnlSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHomeLogo.ResumeLayout(false);
            this.pnlHomeLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHomeTop;
        private System.Windows.Forms.Panel pnlHomeLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSideHome;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnSideSearch;
        private System.Windows.Forms.Button btnSideList;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnHomeFB;
        private System.Windows.Forms.Button btnHomeTwitter;
        private System.Windows.Forms.Button btnHomeGithub;
        private System.Windows.Forms.Button btnHomeNoti;
        private System.Windows.Forms.Button btnHomeSetting;
        private System.Windows.Forms.Button btnHomeExit;
        private System.Windows.Forms.Button btnHomeSlack;
        private System.Windows.Forms.Button btnHomeHelp;
        private System.Windows.Forms.Label lblHomeHelp;
        private System.Windows.Forms.Label label1;
    }
}