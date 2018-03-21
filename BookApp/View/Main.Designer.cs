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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHomeHelp = new System.Windows.Forms.Label();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnSideSearch = new System.Windows.Forms.Button();
            this.btnSideList = new System.Windows.Forms.Button();
            this.btnSideHome = new System.Windows.Forms.Button();
            this.btnHomeHelp = new System.Windows.Forms.Button();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlSidebar.Controls.Add(this.button2);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Controls.Add(this.lblHomeHelp);
            this.pnlSidebar.Controls.Add(this.btnAuthor);
            this.pnlSidebar.Controls.Add(this.btnSideSearch);
            this.pnlSidebar.Controls.Add(this.btnSideList);
            this.pnlSidebar.Controls.Add(this.btnSideHome);
            this.pnlSidebar.Controls.Add(this.btnHomeHelp);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(212, 515);
            this.pnlSidebar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::BookApp.Properties.Resources.Menu_32px;
            this.button2.Location = new System.Drawing.Point(169, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 30);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BookApp.Properties.Resources.favicon_64;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 63);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblHomeHelp
            // 
            this.lblHomeHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnAuthor.Size = new System.Drawing.Size(203, 51);
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
            this.btnSideSearch.Size = new System.Drawing.Size(203, 51);
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
            this.btnSideList.Size = new System.Drawing.Size(203, 51);
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
            this.btnSideHome.Size = new System.Drawing.Size(203, 51);
            this.btnSideHome.TabIndex = 4;
            this.btnSideHome.Text = "           Trang chủ";
            this.btnSideHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideHome.UseVisualStyleBackColor = true;
            this.btnSideHome.Click += new System.EventHandler(this.btnSideHome_Click);
            // 
            // btnHomeHelp
            // 
            this.btnHomeHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlSide.Location = new System.Drawing.Point(0, 128);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(8, 51);
            this.pnlSide.TabIndex = 4;
            // 
            // panelContent
            // 
            this.panelContent.AutoSize = true;
            this.panelContent.Location = new System.Drawing.Point(212, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(812, 512);
            this.panelContent.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 515);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnSideHome;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnSideSearch;
        private System.Windows.Forms.Button btnSideList;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnHomeHelp;
        private System.Windows.Forms.Label lblHomeHelp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContent;
    }
}