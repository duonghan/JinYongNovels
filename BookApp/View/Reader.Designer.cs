namespace BookApp
{
    partial class Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reader));
            this.comboBoxChapterList = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSpellCheck = new System.Windows.Forms.Button();
            this.lblChapName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnBackParent = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCheckError = new System.Windows.Forms.Button();
            this.btnSearchResult = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlSlide = new System.Windows.Forms.ListBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChapterList
            // 
            this.comboBoxChapterList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxChapterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChapterList.FormattingEnabled = true;
            this.comboBoxChapterList.Location = new System.Drawing.Point(374, 23);
            this.comboBoxChapterList.Name = "comboBoxChapterList";
            this.comboBoxChapterList.Size = new System.Drawing.Size(112, 21);
            this.comboBoxChapterList.TabIndex = 0;
            this.comboBoxChapterList.SelectionChangeCommitted += new System.EventHandler(this.comboBoxChapterList_SelectionChangeCommitted);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.BackgroundImage = global::BookApp.Properties.Resources.Next_Page;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(492, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrev.BackgroundImage = global::BookApp.Properties.Resources.Previous_Page;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(333, 15);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 35);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.comboBoxChapterList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 54);
            this.panel2.TabIndex = 1;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.AcceptsReturn = true;
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBoxSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Tiếu ngạo giang hồ",
            "Tiếu",
            "T",
            "Tiếu ngạpo"});
            this.txtBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.White;
            this.txtBoxSearch.Location = new System.Drawing.Point(229, 32);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(20);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(454, 22);
            this.txtBoxSearch.TabIndex = 7;
            this.txtBoxSearch.Text = "Tìm kiếm...";
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSearch.Click += new System.EventHandler(this.Search_Reset);
            this.txtBoxSearch.Enter += new System.EventHandler(this.RemoveText);
            this.txtBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyDown);
            this.txtBoxSearch.Leave += new System.EventHandler(this.AddText);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSearch.BackgroundImage = global::BookApp.Properties.Resources.Search_32px;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(691, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlHeader.Controls.Add(this.btnSpellCheck);
            this.pnlHeader.Controls.Add(this.lblChapName);
            this.pnlHeader.Controls.Add(this.lblBookName);
            this.pnlHeader.Controls.Add(this.btnBackParent);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtBoxSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(874, 96);
            this.pnlHeader.TabIndex = 9;
            // 
            // btnSpellCheck
            // 
            this.btnSpellCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpellCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpellCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpellCheck.Location = new System.Drawing.Point(772, 29);
            this.btnSpellCheck.Name = "btnSpellCheck";
            this.btnSpellCheck.Size = new System.Drawing.Size(75, 27);
            this.btnSpellCheck.TabIndex = 11;
            this.btnSpellCheck.Text = "Kiểm tra";
            this.btnSpellCheck.UseVisualStyleBackColor = true;
            // 
            // lblChapName
            // 
            this.lblChapName.AutoSize = true;
            this.lblChapName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapName.Location = new System.Drawing.Point(57, 63);
            this.lblChapName.Name = "lblChapName";
            this.lblChapName.Size = new System.Drawing.Size(53, 21);
            this.lblChapName.TabIndex = 10;
            this.lblChapName.Text = "label1";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(82, 32);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(52, 19);
            this.lblBookName.TabIndex = 9;
            this.lblBookName.Text = "demo";
            // 
            // btnBackParent
            // 
            this.btnBackParent.BackgroundImage = global::BookApp.Properties.Resources.Back_32px;
            this.btnBackParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackParent.FlatAppearance.BorderSize = 0;
            this.btnBackParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackParent.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackParent.Location = new System.Drawing.Point(12, 27);
            this.btnBackParent.Name = "btnBackParent";
            this.btnBackParent.Size = new System.Drawing.Size(30, 30);
            this.btnBackParent.TabIndex = 0;
            this.btnBackParent.UseVisualStyleBackColor = true;
            this.btnBackParent.Click += new System.EventHandler(this.btnBackParent_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Black;
            this.pnlSidebar.Controls.Add(this.pnlMenu);
            this.pnlSidebar.Controls.Add(this.pnlSlide);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 96);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(249, 350);
            this.pnlSidebar.TabIndex = 10;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnCheckError);
            this.pnlMenu.Controls.Add(this.btnSearchResult);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(42, 351);
            this.pnlMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::BookApp.Properties.Resources.Settings_32px;
            this.button1.Location = new System.Drawing.Point(5, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCheckError
            // 
            this.btnCheckError.FlatAppearance.BorderSize = 0;
            this.btnCheckError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckError.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckError.Image = global::BookApp.Properties.Resources.Error_32px;
            this.btnCheckError.Location = new System.Drawing.Point(5, 195);
            this.btnCheckError.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheckError.Name = "btnCheckError";
            this.btnCheckError.Size = new System.Drawing.Size(32, 32);
            this.btnCheckError.TabIndex = 0;
            this.btnCheckError.UseVisualStyleBackColor = true;
            // 
            // btnSearchResult
            // 
            this.btnSearchResult.FlatAppearance.BorderSize = 0;
            this.btnSearchResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchResult.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchResult.Image = global::BookApp.Properties.Resources.Search_32px;
            this.btnSearchResult.Location = new System.Drawing.Point(5, 153);
            this.btnSearchResult.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchResult.Name = "btnSearchResult";
            this.btnSearchResult.Size = new System.Drawing.Size(32, 32);
            this.btnSearchResult.TabIndex = 0;
            this.btnSearchResult.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetting.Image = global::BookApp.Properties.Resources.List_32px;
            this.btnSetting.Location = new System.Drawing.Point(5, 111);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(32, 32);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pnlSlide
            // 
            this.pnlSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSlide.BackColor = System.Drawing.Color.Black;
            this.pnlSlide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlSlide.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSlide.ForeColor = System.Drawing.Color.White;
            this.pnlSlide.FormattingEnabled = true;
            this.pnlSlide.HorizontalExtent = 30;
            this.pnlSlide.HorizontalScrollbar = true;
            this.pnlSlide.ItemHeight = 20;
            this.pnlSlide.Location = new System.Drawing.Point(44, 4);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(202, 340);
            this.pnlSlide.TabIndex = 0;
            this.pnlSlide.Click += new System.EventHandler(this.listBoxChapter_Click);
            this.pnlSlide.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_DrawItem);
            this.pnlSlide.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lst_MeasureItem);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlContent.Controls.Add(this.rtContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(249, 96);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(625, 350);
            this.pnlContent.TabIndex = 11;
            // 
            // rtContent
            // 
            this.rtContent.AcceptsTab = true;
            this.rtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtContent.BackColor = System.Drawing.Color.Black;
            this.rtContent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtContent.ForeColor = System.Drawing.Color.White;
            this.rtContent.Location = new System.Drawing.Point(3, 3);
            this.rtContent.Name = "rtContent";
            this.rtContent.ReadOnly = true;
            this.rtContent.Size = new System.Drawing.Size(619, 341);
            this.rtContent.TabIndex = 5;
            this.rtContent.Text = "";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reader_FormClosed);
            this.Load += new System.EventHandler(this.showEntryContent);
            this.panel2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChapterList;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnBackParent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ListBox pnlSlide;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblChapName;
        private System.Windows.Forms.Button btnSpellCheck;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCheckError;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button button1;
    }
}