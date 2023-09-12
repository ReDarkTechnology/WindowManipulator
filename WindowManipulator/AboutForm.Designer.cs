namespace WindowManipulator
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.AppDescriptionLabel = new System.Windows.Forms.Label();
            this.supportButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.AutoSize = true;
            this.AppTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AppTitleLabel.Location = new System.Drawing.Point(12, 19);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(190, 25);
            this.AppTitleLabel.TabIndex = 0;
            this.AppTitleLabel.Text = "Window Manipulator";
            // 
            // AppDescriptionLabel
            // 
            this.AppDescriptionLabel.AutoSize = true;
            this.AppDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AppDescriptionLabel.Location = new System.Drawing.Point(14, 48);
            this.AppDescriptionLabel.Name = "AppDescriptionLabel";
            this.AppDescriptionLabel.Size = new System.Drawing.Size(225, 13);
            this.AppDescriptionLabel.TabIndex = 1;
            this.AppDescriptionLabel.Text = "Developed by ReDark Technology (Bunzhida)";
            // 
            // supportButton
            // 
            this.supportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supportButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.supportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supportButton.Location = new System.Drawing.Point(244, 175);
            this.supportButton.Name = "supportButton";
            this.supportButton.Size = new System.Drawing.Size(79, 23);
            this.supportButton.TabIndex = 2;
            this.supportButton.Text = "Support me!";
            this.supportButton.UseVisualStyleBackColor = true;
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Location = new System.Drawing.Point(160, 175);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(79, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Report bug";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.infoLabel.Location = new System.Drawing.Point(14, 75);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(309, 97);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(335, 210);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.AppDescriptionLabel);
            this.Controls.Add(this.AppTitleLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.Label AppDescriptionLabel;
        private System.Windows.Forms.Button supportButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label infoLabel;
    }
}