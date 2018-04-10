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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChapName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnBackParent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxChapter = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(492, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(331, 23);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.lblChapName);
            this.panel1.Controls.Add(this.lblBookName);
            this.panel1.Controls.Add(this.btnBackParent);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtBoxSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 96);
            this.panel1.TabIndex = 9;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.listBoxChapter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 350);
            this.panel3.TabIndex = 10;
            // 
            // listBoxChapter
            // 
            this.listBoxChapter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxChapter.BackColor = System.Drawing.Color.Black;
            this.listBoxChapter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxChapter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChapter.ForeColor = System.Drawing.Color.White;
            this.listBoxChapter.FormattingEnabled = true;
            this.listBoxChapter.HorizontalExtent = 30;
            this.listBoxChapter.HorizontalScrollbar = true;
            this.listBoxChapter.ItemHeight = 20;
            this.listBoxChapter.Location = new System.Drawing.Point(3, 6);
            this.listBoxChapter.Name = "listBoxChapter";
            this.listBoxChapter.Size = new System.Drawing.Size(217, 340);
            this.listBoxChapter.TabIndex = 0;
            this.listBoxChapter.Click += new System.EventHandler(this.listBoxChapter_Click);
            this.listBoxChapter.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_DrawItem);
            this.listBoxChapter.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lst_MeasureItem);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel4.Controls.Add(this.rtContent);
            this.panel4.Location = new System.Drawing.Point(229, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 350);
            this.panel4.TabIndex = 11;
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
            this.rtContent.Size = new System.Drawing.Size(639, 341);
            this.rtContent.TabIndex = 5;
            this.rtContent.Text = "";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChapterList;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackParent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBoxChapter;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblChapName;
    }
}