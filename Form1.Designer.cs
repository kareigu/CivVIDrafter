namespace CivVIDrafter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuDebugAppendConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsoleShowButton = new System.Windows.Forms.Button();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PlayercountSelector = new System.Windows.Forms.ComboBox();
            this.PlayercountSelectorLabel = new System.Windows.Forms.Label();
            this.FileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuFile,
            this.FileMenuHelp,
            this.FileMenuDebug});
            this.FileMenu.Location = new System.Drawing.Point(0, 0);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(502, 24);
            this.FileMenu.TabIndex = 0;
            this.FileMenu.Text = "FileMenu";
            // 
            // FileMenuFile
            // 
            this.FileMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuFileExit});
            this.FileMenuFile.Name = "FileMenuFile";
            this.FileMenuFile.Size = new System.Drawing.Size(37, 20);
            this.FileMenuFile.Text = "File";
            // 
            // FileMenuFileExit
            // 
            this.FileMenuFileExit.Name = "FileMenuFileExit";
            this.FileMenuFileExit.Size = new System.Drawing.Size(92, 22);
            this.FileMenuFileExit.Text = "Exit";
            this.FileMenuFileExit.Click += new System.EventHandler(this.FileMenuFileExit_Click);
            // 
            // FileMenuHelp
            // 
            this.FileMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuHelpAbout});
            this.FileMenuHelp.Name = "FileMenuHelp";
            this.FileMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.FileMenuHelp.Text = "Help";
            // 
            // FileMenuHelpAbout
            // 
            this.FileMenuHelpAbout.Name = "FileMenuHelpAbout";
            this.FileMenuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.FileMenuHelpAbout.Text = "About";
            this.FileMenuHelpAbout.Click += new System.EventHandler(this.FileMenuHelpAbout_Click);
            // 
            // FileMenuDebug
            // 
            this.FileMenuDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuDebugAppendConsole});
            this.FileMenuDebug.Name = "FileMenuDebug";
            this.FileMenuDebug.Size = new System.Drawing.Size(54, 20);
            this.FileMenuDebug.Text = "Debug";
            // 
            // FileMenuDebugAppendConsole
            // 
            this.FileMenuDebugAppendConsole.Name = "FileMenuDebugAppendConsole";
            this.FileMenuDebugAppendConsole.Size = new System.Drawing.Size(180, 22);
            this.FileMenuDebugAppendConsole.Text = "Append Console";
            this.FileMenuDebugAppendConsole.Click += new System.EventHandler(this.FileMenuDebugAppendConsole_Click);
            // 
            // ConsoleShowButton
            // 
            this.ConsoleShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleShowButton.Image = ((System.Drawing.Image)(resources.GetObject("ConsoleShowButton.Image")));
            this.ConsoleShowButton.Location = new System.Drawing.Point(472, 0);
            this.ConsoleShowButton.Name = "ConsoleShowButton";
            this.ConsoleShowButton.Size = new System.Drawing.Size(30, 24);
            this.ConsoleShowButton.TabIndex = 1;
            this.ConsoleShowButton.UseVisualStyleBackColor = true;
            this.ConsoleShowButton.Click += new System.EventHandler(this.ConsoleShowButton_Click);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsoleBox.Enabled = false;
            this.ConsoleBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ConsoleBox.HideSelection = false;
            this.ConsoleBox.Location = new System.Drawing.Point(12, 422);
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(478, 157);
            this.ConsoleBox.TabIndex = 2;
            this.ConsoleBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CivVIDrafter.Properties.Resources.pingalaJoy;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GenerateButton.Location = new System.Drawing.Point(210, 550);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "button1";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // PlayercountSelector
            // 
            this.PlayercountSelector.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.PlayercountSelector.FormattingEnabled = true;
            this.PlayercountSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.PlayercountSelector.Location = new System.Drawing.Point(12, 39);
            this.PlayercountSelector.Name = "PlayercountSelector";
            this.PlayercountSelector.Size = new System.Drawing.Size(121, 21);
            this.PlayercountSelector.TabIndex = 6;
            this.PlayercountSelector.Text = "4";
            // 
            // PlayercountSelectorLabel
            // 
            this.PlayercountSelectorLabel.AutoSize = true;
            this.PlayercountSelectorLabel.Location = new System.Drawing.Point(29, 24);
            this.PlayercountSelectorLabel.Name = "PlayercountSelectorLabel";
            this.PlayercountSelectorLabel.Size = new System.Drawing.Size(63, 13);
            this.PlayercountSelectorLabel.TabIndex = 7;
            this.PlayercountSelectorLabel.Text = "Playercount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 583);
            this.Controls.Add(this.PlayercountSelectorLabel);
            this.Controls.Add(this.PlayercountSelector);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.ConsoleShowButton);
            this.Controls.Add(this.FileMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.FileMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 622);
            this.MinimumSize = new System.Drawing.Size(518, 622);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuFile;
        private System.Windows.Forms.ToolStripMenuItem FileMenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem FileMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem FileMenuHelpAbout;
        private System.Windows.Forms.Button ConsoleShowButton;
        private System.Windows.Forms.TextBox ConsoleBox;
        private System.Windows.Forms.ToolStripMenuItem FileMenuDebug;
        private System.Windows.Forms.ToolStripMenuItem FileMenuDebugAppendConsole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ComboBox PlayercountSelector;
        private System.Windows.Forms.Label PlayercountSelectorLabel;
    }
}

