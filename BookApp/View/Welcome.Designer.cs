namespace BookApp
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.btnWelcomeStart = new System.Windows.Forms.Button();
            this.btnWelcomeExit = new System.Windows.Forms.Button();
            this.btnWelcomeCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWelcomeStart
            // 
            this.btnWelcomeStart.AccessibleName = "";
            this.btnWelcomeStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWelcomeStart.AutoSize = true;
            this.btnWelcomeStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWelcomeStart.FlatAppearance.BorderSize = 0;
            this.btnWelcomeStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcomeStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWelcomeStart.Location = new System.Drawing.Point(309, 158);
            this.btnWelcomeStart.Name = "btnWelcomeStart";
            this.btnWelcomeStart.Size = new System.Drawing.Size(114, 40);
            this.btnWelcomeStart.TabIndex = 0;
            this.btnWelcomeStart.Text = "Đọc truyện";
            this.btnWelcomeStart.UseVisualStyleBackColor = false;
            this.btnWelcomeStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnWelcomeExit
            // 
            this.btnWelcomeExit.AccessibleName = "";
            this.btnWelcomeExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWelcomeExit.AutoSize = true;
            this.btnWelcomeExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnWelcomeExit.FlatAppearance.BorderSize = 0;
            this.btnWelcomeExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcomeExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWelcomeExit.Location = new System.Drawing.Point(309, 250);
            this.btnWelcomeExit.Name = "btnWelcomeExit";
            this.btnWelcomeExit.Size = new System.Drawing.Size(114, 40);
            this.btnWelcomeExit.TabIndex = 0;
            this.btnWelcomeExit.Text = "Thoát";
            this.btnWelcomeExit.UseVisualStyleBackColor = false;
            this.btnWelcomeExit.Click += new System.EventHandler(this.btnWelcomeExit_Click);
            // 
            // btnWelcomeCont
            // 
            this.btnWelcomeCont.AccessibleName = "";
            this.btnWelcomeCont.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWelcomeCont.AutoSize = true;
            this.btnWelcomeCont.BackColor = System.Drawing.Color.ForestGreen;
            this.btnWelcomeCont.FlatAppearance.BorderSize = 0;
            this.btnWelcomeCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeCont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcomeCont.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWelcomeCont.Location = new System.Drawing.Point(309, 204);
            this.btnWelcomeCont.Name = "btnWelcomeCont";
            this.btnWelcomeCont.Size = new System.Drawing.Size(114, 40);
            this.btnWelcomeCont.TabIndex = 0;
            this.btnWelcomeCont.Text = "Đọc tiếp";
            this.btnWelcomeCont.UseVisualStyleBackColor = false;
            this.btnWelcomeCont.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookApp.Properties.Resources.welcome_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 417);
            this.Controls.Add(this.btnWelcomeExit);
            this.Controls.Add(this.btnWelcomeCont);
            this.Controls.Add(this.btnWelcomeStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.Text = "Đọc truyện Kim Dung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWelcomeStart;
        private System.Windows.Forms.Button btnWelcomeExit;
        private System.Windows.Forms.Button btnWelcomeCont;
    }
}

