namespace game2048
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.mainMenu = new System.Windows.Forms.Panel();
            this.specButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.Specification = new System.Windows.Forms.Panel();
            this.textSpec = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.labelSpec = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.Specification.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.mainMenu.Controls.Add(this.specButton);
            this.mainMenu.Controls.Add(this.startButton);
            this.mainMenu.Controls.Add(this.labelMenu);
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(522, 694);
            this.mainMenu.TabIndex = 0;
            // 
            // specButton
            // 
            this.specButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.specButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.specButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specButton.ForeColor = System.Drawing.Color.White;
            this.specButton.Location = new System.Drawing.Point(142, 350);
            this.specButton.Name = "specButton";
            this.specButton.Size = new System.Drawing.Size(239, 64);
            this.specButton.TabIndex = 10;
            this.specButton.Text = "Quy tắc";
            this.specButton.UseVisualStyleBackColor = false;
            this.specButton.Click += new System.EventHandler(this.specButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(142, 270);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(239, 66);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Bắt đầu";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(102)))));
            this.labelMenu.Location = new System.Drawing.Point(187, 172);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(136, 55);
            this.labelMenu.TabIndex = 8;
            this.labelMenu.Text = "2048";
            // 
            // Specification
            // 
            this.Specification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.Specification.Controls.Add(this.textSpec);
            this.Specification.Controls.Add(this.backButton);
            this.Specification.Controls.Add(this.labelSpec);
            this.Specification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Specification.Location = new System.Drawing.Point(0, 0);
            this.Specification.Name = "Specification";
            this.Specification.Size = new System.Drawing.Size(522, 682);
            this.Specification.TabIndex = 1;
            // 
            // textSpec
            // 
            this.textSpec.AutoSize = true;
            this.textSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSpec.Location = new System.Drawing.Point(24, 125);
            this.textSpec.Name = "textSpec";
            this.textSpec.Size = new System.Drawing.Size(119, 20);
            this.textSpec.TabIndex = 11;
            this.textSpec.Text = "Quy tắc trò chơi";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(29, 606);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 59);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Quay lại";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(102)))));
            this.labelSpec.Location = new System.Drawing.Point(73, 30);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(196, 55);
            this.labelSpec.TabIndex = 9;
            this.labelSpec.Text = "Quy tắc";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 682);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.Specification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.Specification.ResumeLayout(false);
            this.Specification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Button specButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel Specification;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label textSpec;
    }
}
