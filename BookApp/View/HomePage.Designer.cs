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
            this.SuspendLayout();
            // 
            // btnReadContinue
            // 
            this.btnReadContinue.BackColor = System.Drawing.Color.Crimson;
            this.btnReadContinue.FlatAppearance.BorderSize = 0;
            this.btnReadContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadContinue.ForeColor = System.Drawing.Color.White;
            this.btnReadContinue.Location = new System.Drawing.Point(75, 275);
            this.btnReadContinue.Name = "btnReadContinue";
            this.btnReadContinue.Size = new System.Drawing.Size(163, 50);
            this.btnReadContinue.TabIndex = 0;
            this.btnReadContinue.Text = "Đọc tiếp ...";
            this.btnReadContinue.UseVisualStyleBackColor = false;
            // 
            // pnlBookImage
            // 
            this.pnlBookImage.Location = new System.Drawing.Point(61, 26);
            this.pnlBookImage.Name = "pnlBookImage";
            this.pnlBookImage.Size = new System.Drawing.Size(195, 232);
            this.pnlBookImage.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlBookImage);
            this.Controls.Add(this.btnReadContinue);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(813, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadContinue;
        private System.Windows.Forms.Panel pnlBookImage;
    }
}
