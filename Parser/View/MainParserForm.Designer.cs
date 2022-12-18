namespace Parser
{
    partial class MainParserForm : Form
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button currrent_button;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainParserForm));
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.brandPanel = new System.Windows.Forms.Panel();
            this.brandLabel = new System.Windows.Forms.Label();
            this.parserButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.horizontalLineLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.mainWorkPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.brandPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "text file |*.txt|CSV file |*.csv";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // brandPanel
            // 
            this.brandPanel.Controls.Add(this.brandLabel);
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandPanel.Location = new System.Drawing.Point(25, 25);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Padding = new System.Windows.Forms.Padding(20);
            this.brandPanel.Size = new System.Drawing.Size(250, 113);
            this.brandPanel.TabIndex = 0;
            // 
            // brandLabel
            // 
            this.brandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandLabel.ForeColor = System.Drawing.Color.Black;
            this.brandLabel.Location = new System.Drawing.Point(20, 20);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(210, 73);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Parser App";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parserButton
            // 
            this.parserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parserButton.FlatAppearance.BorderSize = 0;
            this.parserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parserButton.ForeColor = System.Drawing.Color.Black;
            this.parserButton.Location = new System.Drawing.Point(25, 138);
            this.parserButton.Name = "parserButton";
            this.parserButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.parserButton.Size = new System.Drawing.Size(250, 60);
            this.parserButton.TabIndex = 1;
            this.parserButton.Text = "Parser";
            this.parserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parserButton.UseVisualStyleBackColor = true;
            this.parserButton.Click += new System.EventHandler(this.ParserButtonClick);
            // 
            // aboutButton
            // 
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutButton.ForeColor = System.Drawing.Color.Black;
            this.aboutButton.Location = new System.Drawing.Point(25, 198);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.aboutButton.Size = new System.Drawing.Size(250, 60);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButtonClick);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AllowDrop = true;
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileNameLabel.ForeColor = System.Drawing.Color.Black;
            this.fileNameLabel.Location = new System.Drawing.Point(25, 911);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(250, 33);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "Filename: ";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // horizontalLineLabel
            // 
            this.horizontalLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLineLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.horizontalLineLabel.Location = new System.Drawing.Point(25, 258);
            this.horizontalLineLabel.Name = "horizontalLineLabel";
            this.horizontalLineLabel.Size = new System.Drawing.Size(250, 2);
            this.horizontalLineLabel.TabIndex = 5;
            // 
            // loadButton
            // 
            this.loadButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Location = new System.Drawing.Point(25, 865);
            this.loadButton.Name = "loadButton";
            this.loadButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.loadButton.Size = new System.Drawing.Size(250, 46);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load Text File";
            this.loadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.loadButton);
            this.menuPanel.Controls.Add(this.horizontalLineLabel);
            this.menuPanel.Controls.Add(this.fileNameLabel);
            this.menuPanel.Controls.Add(this.aboutButton);
            this.menuPanel.Controls.Add(this.parserButton);
            this.menuPanel.Controls.Add(this.brandPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.MinimumSize = new System.Drawing.Size(300, 400);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(25, 25, 25, 0);
            this.menuPanel.Size = new System.Drawing.Size(300, 944);
            this.menuPanel.TabIndex = 0;
            // 
            // mainWorkPanel
            // 
            this.mainWorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWorkPanel.Location = new System.Drawing.Point(300, 0);
            this.mainWorkPanel.Name = "mainWorkPanel";
            this.mainWorkPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainWorkPanel.Size = new System.Drawing.Size(878, 944);
            this.mainWorkPanel.TabIndex = 2;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.statusLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.Location = new System.Drawing.Point(300, 911);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(878, 33);
            this.statusPanel.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(878, 33);
            this.statusLabel.TabIndex = 25;
            this.statusLabel.Text = "Ready";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainParserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScrollMargin = new System.Drawing.Size(700, 500);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.mainWorkPanel);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 460);
            this.Name = "MainParserForm";
            this.Text = "Parser";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.brandPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private ColumnHeader columnHeader1;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel mainWorkPanel;
        private Panel menuPanel;
        private Button loadButton;
        private Label horizontalLineLabel;
        private Label fileNameLabel;
        private Button aboutButton;
        private Button parserButton;
        private Panel brandPanel;
        private Label brandLabel;
        private Panel statusPanel;
        private Label statusLabel;
    }
}