namespace WindowManipulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ScreenArea = new System.Windows.Forms.Panel();
            this.FormBounds = new System.Windows.Forms.Panel();
            this.InspectorPanel = new System.Windows.Forms.Panel();
            this.I_StyleCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.I_CloseProcessButton = new System.Windows.Forms.Button();
            this.I_KillProcessButton = new System.Windows.Forms.Button();
            this.I_ApplyStyleButton = new System.Windows.Forms.Button();
            this.I_StyleLabel = new System.Windows.Forms.Label();
            this.I_ApplyStateButton = new System.Windows.Forms.Button();
            this.I_StateDropdown = new System.Windows.Forms.ComboBox();
            this.I_StateLabel = new System.Windows.Forms.Label();
            this.I_SizeBoxY = new System.Windows.Forms.TextBox();
            this.I_SizeBoxX = new System.Windows.Forms.TextBox();
            this.I_SizeLabel = new System.Windows.Forms.Label();
            this.I_ProcessIDBox = new System.Windows.Forms.TextBox();
            this.I_ProcessNameBox = new System.Windows.Forms.TextBox();
            this.I_ProcessLabel = new System.Windows.Forms.Label();
            this.I_PositionBoxY = new System.Windows.Forms.TextBox();
            this.I_PositionBoxX = new System.Windows.Forms.TextBox();
            this.I_PositionLabel = new System.Windows.Forms.Label();
            this.I_TitleBox = new System.Windows.Forms.TextBox();
            this.I_TitleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormBounds.SuspendLayout();
            this.InspectorPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenArea
            // 
            this.ScreenArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenArea.Location = new System.Drawing.Point(0, 0);
            this.ScreenArea.Name = "ScreenArea";
            this.ScreenArea.Size = new System.Drawing.Size(620, 426);
            this.ScreenArea.TabIndex = 0;
            // 
            // FormBounds
            // 
            this.FormBounds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormBounds.Controls.Add(this.InspectorPanel);
            this.FormBounds.Controls.Add(this.ScreenArea);
            this.FormBounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBounds.Location = new System.Drawing.Point(0, 24);
            this.FormBounds.Name = "FormBounds";
            this.FormBounds.Size = new System.Drawing.Size(800, 426);
            this.FormBounds.TabIndex = 1;
            // 
            // InspectorPanel
            // 
            this.InspectorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InspectorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InspectorPanel.Controls.Add(this.I_StyleCheckBoxList);
            this.InspectorPanel.Controls.Add(this.I_CloseProcessButton);
            this.InspectorPanel.Controls.Add(this.I_KillProcessButton);
            this.InspectorPanel.Controls.Add(this.I_ApplyStyleButton);
            this.InspectorPanel.Controls.Add(this.I_StyleLabel);
            this.InspectorPanel.Controls.Add(this.I_ApplyStateButton);
            this.InspectorPanel.Controls.Add(this.I_StateDropdown);
            this.InspectorPanel.Controls.Add(this.I_StateLabel);
            this.InspectorPanel.Controls.Add(this.I_SizeBoxY);
            this.InspectorPanel.Controls.Add(this.I_SizeBoxX);
            this.InspectorPanel.Controls.Add(this.I_SizeLabel);
            this.InspectorPanel.Controls.Add(this.I_ProcessIDBox);
            this.InspectorPanel.Controls.Add(this.I_ProcessNameBox);
            this.InspectorPanel.Controls.Add(this.I_ProcessLabel);
            this.InspectorPanel.Controls.Add(this.I_PositionBoxY);
            this.InspectorPanel.Controls.Add(this.I_PositionBoxX);
            this.InspectorPanel.Controls.Add(this.I_PositionLabel);
            this.InspectorPanel.Controls.Add(this.I_TitleBox);
            this.InspectorPanel.Controls.Add(this.I_TitleLabel);
            this.InspectorPanel.Location = new System.Drawing.Point(620, 0);
            this.InspectorPanel.Name = "InspectorPanel";
            this.InspectorPanel.Size = new System.Drawing.Size(180, 426);
            this.InspectorPanel.TabIndex = 1;
            // 
            // I_StyleCheckBoxList
            // 
            this.I_StyleCheckBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_StyleCheckBoxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.I_StyleCheckBoxList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_StyleCheckBoxList.CheckOnClick = true;
            this.I_StyleCheckBoxList.Cursor = System.Windows.Forms.Cursors.Default;
            this.I_StyleCheckBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_StyleCheckBoxList.FormattingEnabled = true;
            this.I_StyleCheckBoxList.Location = new System.Drawing.Point(10, 274);
            this.I_StyleCheckBoxList.Name = "I_StyleCheckBoxList";
            this.I_StyleCheckBoxList.Size = new System.Drawing.Size(158, 107);
            this.I_StyleCheckBoxList.TabIndex = 19;
            // 
            // I_CloseProcessButton
            // 
            this.I_CloseProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.I_CloseProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_CloseProcessButton.Location = new System.Drawing.Point(59, 391);
            this.I_CloseProcessButton.Name = "I_CloseProcessButton";
            this.I_CloseProcessButton.Size = new System.Drawing.Size(52, 23);
            this.I_CloseProcessButton.TabIndex = 18;
            this.I_CloseProcessButton.Text = "Close";
            this.I_CloseProcessButton.UseVisualStyleBackColor = true;
            this.I_CloseProcessButton.Click += new System.EventHandler(this.I_CloseProcessButton_Click);
            // 
            // I_KillProcessButton
            // 
            this.I_KillProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.I_KillProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_KillProcessButton.Location = new System.Drawing.Point(117, 391);
            this.I_KillProcessButton.Name = "I_KillProcessButton";
            this.I_KillProcessButton.Size = new System.Drawing.Size(52, 23);
            this.I_KillProcessButton.TabIndex = 17;
            this.I_KillProcessButton.Text = "Kill";
            this.I_KillProcessButton.UseVisualStyleBackColor = true;
            this.I_KillProcessButton.Click += new System.EventHandler(this.I_KillProcessButton_Click);
            // 
            // I_ApplyStyleButton
            // 
            this.I_ApplyStyleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.I_ApplyStyleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_ApplyStyleButton.Location = new System.Drawing.Point(116, 245);
            this.I_ApplyStyleButton.Name = "I_ApplyStyleButton";
            this.I_ApplyStyleButton.Size = new System.Drawing.Size(52, 23);
            this.I_ApplyStyleButton.TabIndex = 16;
            this.I_ApplyStyleButton.Text = "Apply";
            this.I_ApplyStyleButton.UseVisualStyleBackColor = true;
            this.I_ApplyStyleButton.Click += new System.EventHandler(this.I_ApplyStyleButton_Click);
            // 
            // I_StyleLabel
            // 
            this.I_StyleLabel.AutoSize = true;
            this.I_StyleLabel.Location = new System.Drawing.Point(7, 249);
            this.I_StyleLabel.Name = "I_StyleLabel";
            this.I_StyleLabel.Size = new System.Drawing.Size(72, 13);
            this.I_StyleLabel.TabIndex = 15;
            this.I_StyleLabel.Text = "Window Style";
            // 
            // I_ApplyStateButton
            // 
            this.I_ApplyStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.I_ApplyStateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I_ApplyStateButton.Location = new System.Drawing.Point(116, 191);
            this.I_ApplyStateButton.Name = "I_ApplyStateButton";
            this.I_ApplyStateButton.Size = new System.Drawing.Size(52, 23);
            this.I_ApplyStateButton.TabIndex = 13;
            this.I_ApplyStateButton.Text = "Apply";
            this.I_ApplyStateButton.UseVisualStyleBackColor = true;
            this.I_ApplyStateButton.Click += new System.EventHandler(this.I_ApplyStateButton_Click);
            // 
            // I_StateDropdown
            // 
            this.I_StateDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_StateDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.I_StateDropdown.FormattingEnabled = true;
            this.I_StateDropdown.Location = new System.Drawing.Point(10, 218);
            this.I_StateDropdown.Name = "I_StateDropdown";
            this.I_StateDropdown.Size = new System.Drawing.Size(158, 21);
            this.I_StateDropdown.TabIndex = 12;
            // 
            // I_StateLabel
            // 
            this.I_StateLabel.AutoSize = true;
            this.I_StateLabel.Location = new System.Drawing.Point(7, 195);
            this.I_StateLabel.Name = "I_StateLabel";
            this.I_StateLabel.Size = new System.Drawing.Size(74, 13);
            this.I_StateLabel.TabIndex = 11;
            this.I_StateLabel.Text = "Window State";
            // 
            // I_SizeBoxY
            // 
            this.I_SizeBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_SizeBoxY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.I_SizeBoxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_SizeBoxY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_SizeBoxY.Location = new System.Drawing.Point(91, 165);
            this.I_SizeBoxY.Name = "I_SizeBoxY";
            this.I_SizeBoxY.Size = new System.Drawing.Size(78, 20);
            this.I_SizeBoxY.TabIndex = 10;
            this.I_SizeBoxY.TextChanged += new System.EventHandler(this.I_SizeBoxY_TextChanged);
            // 
            // I_SizeBoxX
            // 
            this.I_SizeBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_SizeBoxX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.I_SizeBoxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_SizeBoxX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_SizeBoxX.Location = new System.Drawing.Point(10, 165);
            this.I_SizeBoxX.Name = "I_SizeBoxX";
            this.I_SizeBoxX.Size = new System.Drawing.Size(75, 20);
            this.I_SizeBoxX.TabIndex = 9;
            this.I_SizeBoxX.TextChanged += new System.EventHandler(this.I_SizeBoxX_TextChanged);
            // 
            // I_SizeLabel
            // 
            this.I_SizeLabel.AutoSize = true;
            this.I_SizeLabel.Location = new System.Drawing.Point(7, 146);
            this.I_SizeLabel.Name = "I_SizeLabel";
            this.I_SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.I_SizeLabel.TabIndex = 8;
            this.I_SizeLabel.Text = "Size";
            // 
            // I_ProcessIDBox
            // 
            this.I_ProcessIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_ProcessIDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.I_ProcessIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_ProcessIDBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_ProcessIDBox.Location = new System.Drawing.Point(101, 73);
            this.I_ProcessIDBox.Name = "I_ProcessIDBox";
            this.I_ProcessIDBox.ReadOnly = true;
            this.I_ProcessIDBox.Size = new System.Drawing.Size(67, 20);
            this.I_ProcessIDBox.TabIndex = 7;
            // 
            // I_ProcessNameBox
            // 
            this.I_ProcessNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_ProcessNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.I_ProcessNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_ProcessNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_ProcessNameBox.Location = new System.Drawing.Point(9, 73);
            this.I_ProcessNameBox.Name = "I_ProcessNameBox";
            this.I_ProcessNameBox.ReadOnly = true;
            this.I_ProcessNameBox.Size = new System.Drawing.Size(86, 20);
            this.I_ProcessNameBox.TabIndex = 6;
            // 
            // I_ProcessLabel
            // 
            this.I_ProcessLabel.AutoSize = true;
            this.I_ProcessLabel.Location = new System.Drawing.Point(6, 54);
            this.I_ProcessLabel.Name = "I_ProcessLabel";
            this.I_ProcessLabel.Size = new System.Drawing.Size(45, 13);
            this.I_ProcessLabel.TabIndex = 5;
            this.I_ProcessLabel.Text = "Process";
            // 
            // I_PositionBoxY
            // 
            this.I_PositionBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_PositionBoxY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.I_PositionBoxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_PositionBoxY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_PositionBoxY.Location = new System.Drawing.Point(90, 119);
            this.I_PositionBoxY.Name = "I_PositionBoxY";
            this.I_PositionBoxY.Size = new System.Drawing.Size(78, 20);
            this.I_PositionBoxY.TabIndex = 4;
            this.I_PositionBoxY.TextChanged += new System.EventHandler(this.I_PositionBoxY_TextChanged);
            // 
            // I_PositionBoxX
            // 
            this.I_PositionBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_PositionBoxX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.I_PositionBoxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_PositionBoxX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_PositionBoxX.Location = new System.Drawing.Point(9, 119);
            this.I_PositionBoxX.Name = "I_PositionBoxX";
            this.I_PositionBoxX.Size = new System.Drawing.Size(75, 20);
            this.I_PositionBoxX.TabIndex = 3;
            this.I_PositionBoxX.TextChanged += new System.EventHandler(this.I_PositionBoxX_TextChanged);
            // 
            // I_PositionLabel
            // 
            this.I_PositionLabel.AutoSize = true;
            this.I_PositionLabel.Location = new System.Drawing.Point(6, 100);
            this.I_PositionLabel.Name = "I_PositionLabel";
            this.I_PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.I_PositionLabel.TabIndex = 2;
            this.I_PositionLabel.Text = "Position";
            // 
            // I_TitleBox
            // 
            this.I_TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_TitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.I_TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I_TitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.I_TitleBox.Location = new System.Drawing.Point(9, 29);
            this.I_TitleBox.Name = "I_TitleBox";
            this.I_TitleBox.ReadOnly = true;
            this.I_TitleBox.Size = new System.Drawing.Size(159, 20);
            this.I_TitleBox.TabIndex = 1;
            // 
            // I_TitleLabel
            // 
            this.I_TitleLabel.AutoSize = true;
            this.I_TitleLabel.Location = new System.Drawing.Point(6, 10);
            this.I_TitleLabel.Name = "I_TitleLabel";
            this.I_TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.I_TitleLabel.TabIndex = 0;
            this.I_TitleLabel.Text = "Title";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findProcessToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // findProcessToolStripMenuItem
            // 
            this.findProcessToolStripMenuItem.Name = "findProcessToolStripMenuItem";
            this.findProcessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findProcessToolStripMenuItem.Text = "Find Process";
            this.findProcessToolStripMenuItem.Click += new System.EventHandler(this.findProcessToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormBounds);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Window Manipulator";
            this.FormBounds.ResumeLayout(false);
            this.InspectorPanel.ResumeLayout(false);
            this.InspectorPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ScreenArea;
        private System.Windows.Forms.Panel FormBounds;
        private System.Windows.Forms.Panel InspectorPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findProcessToolStripMenuItem;
        private System.Windows.Forms.Label I_TitleLabel;
        private System.Windows.Forms.TextBox I_TitleBox;
        private System.Windows.Forms.TextBox I_PositionBoxX;
        private System.Windows.Forms.Label I_PositionLabel;
        private System.Windows.Forms.TextBox I_PositionBoxY;
        private System.Windows.Forms.Label I_ProcessLabel;
        private System.Windows.Forms.TextBox I_ProcessIDBox;
        private System.Windows.Forms.TextBox I_ProcessNameBox;
        private System.Windows.Forms.TextBox I_SizeBoxY;
        private System.Windows.Forms.TextBox I_SizeBoxX;
        private System.Windows.Forms.Label I_SizeLabel;
        private System.Windows.Forms.Label I_StateLabel;
        private System.Windows.Forms.ComboBox I_StateDropdown;
        private System.Windows.Forms.Button I_ApplyStateButton;
        private System.Windows.Forms.Button I_ApplyStyleButton;
        private System.Windows.Forms.Label I_StyleLabel;
        private System.Windows.Forms.Button I_KillProcessButton;
        private System.Windows.Forms.Button I_CloseProcessButton;
        private System.Windows.Forms.CheckedListBox I_StyleCheckBoxList;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

