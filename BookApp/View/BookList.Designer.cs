namespace BookApp
{
    partial class BookList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHomeTop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flpBook = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHomeTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHomeTop
            // 
            this.pnlHomeTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlHomeTop.Controls.Add(this.button1);
            this.pnlHomeTop.Controls.Add(this.textBox1);
            this.pnlHomeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomeTop.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeTop.Name = "pnlHomeTop";
            this.pnlHomeTop.Size = new System.Drawing.Size(785, 77);
            this.pnlHomeTop.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Tiếu ngạo giang hồ",
            "Tiếu",
            "T",
            "Tiếu ngạpo"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(36, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Tìm kiếm...";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BookApp.Properties.Resources.Search_32px;
            this.button1.Location = new System.Drawing.Point(584, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flpBook
            // 
            this.flpBook.Location = new System.Drawing.Point(3, 83);
            this.flpBook.Name = "flpBook";
            this.flpBook.Size = new System.Drawing.Size(779, 413);
            this.flpBook.TabIndex = 3;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.flpBook);
            this.Controls.Add(this.pnlHomeTop);
            this.Name = "BookList";
            this.Size = new System.Drawing.Size(785, 499);
            this.pnlHomeTop.ResumeLayout(false);
            this.pnlHomeTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHomeTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flpBook;
    }
}
