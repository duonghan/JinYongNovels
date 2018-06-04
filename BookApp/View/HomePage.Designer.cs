namespace BookApp
{
    partial class HomePage
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
            this.btnReadContinue = new System.Windows.Forms.Button();
            this.pnlBookImage = new System.Windows.Forms.Panel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadContinue
            // 
            this.btnReadContinue.BackColor = System.Drawing.Color.Crimson;
            this.btnReadContinue.FlatAppearance.BorderSize = 0;
            this.btnReadContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadContinue.ForeColor = System.Drawing.Color.White;
            this.btnReadContinue.Location = new System.Drawing.Point(289, 281);
            this.btnReadContinue.Name = "btnReadContinue";
            this.btnReadContinue.Size = new System.Drawing.Size(163, 50);
            this.btnReadContinue.TabIndex = 0;
            this.btnReadContinue.Text = "Đọc tiếp ...";
            this.btnReadContinue.UseVisualStyleBackColor = false;
            this.btnReadContinue.Click += new System.EventHandler(this.book_Click);
            // 
            // pnlBookImage
            // 
            this.pnlBookImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBookImage.Location = new System.Drawing.Point(61, 26);
            this.pnlBookImage.Name = "pnlBookImage";
            this.pnlBookImage.Size = new System.Drawing.Size(195, 232);
            this.pnlBookImage.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookName.Location = new System.Drawing.Point(284, 48);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(66, 30);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "label1";
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookStatus.Location = new System.Drawing.Point(284, 101);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookStatus.Size = new System.Drawing.Size(62, 25);
            this.lblBookStatus.TabIndex = 2;
            this.lblBookStatus.Text = "label1";
            this.lblBookStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblBookStatus);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pnlBookImage);
            this.Controls.Add(this.btnReadContinue);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(813, 369);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.VisibleChanged += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadContinue;
        private System.Windows.Forms.Panel pnlBookImage;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookStatus;
    }
}
