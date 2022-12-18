namespace Parser.View
{
    partial class ParserFunctionForm
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
            this.parserLogicPanel = new System.Windows.Forms.Panel();
            this.parserPanelPlaceholder = new System.Windows.Forms.Panel();
            this.abortButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.parseButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.emptySpacingLabel2 = new System.Windows.Forms.Label();
            this.parserListView = new System.Windows.Forms.ListView();
            this.wordsColumn = new System.Windows.Forms.ColumnHeader();
            this.occurencesColumn = new System.Windows.Forms.ColumnHeader();
            this.subtitleParserLabel = new System.Windows.Forms.Label();
            this.parserLogicPanel.SuspendLayout();
            this.parserPanelPlaceholder.SuspendLayout();
            this.SuspendLayout();
            // 
            // parserLogicPanel
            // 
            this.parserLogicPanel.AutoScroll = true;
            this.parserLogicPanel.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.parserLogicPanel.AutoScrollMinSize = new System.Drawing.Size(0, 50);
            this.parserLogicPanel.AutoSize = true;
            this.parserLogicPanel.BackColor = System.Drawing.Color.White;
            this.parserLogicPanel.Controls.Add(this.parserPanelPlaceholder);
            this.parserLogicPanel.Controls.Add(this.progressBar);
            this.parserLogicPanel.Controls.Add(this.emptySpacingLabel2);
            this.parserLogicPanel.Controls.Add(this.parserListView);
            this.parserLogicPanel.Controls.Add(this.subtitleParserLabel);
            this.parserLogicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parserLogicPanel.Location = new System.Drawing.Point(0, 0);
            this.parserLogicPanel.Name = "parserLogicPanel";
            this.parserLogicPanel.Padding = new System.Windows.Forms.Padding(25);
            this.parserLogicPanel.Size = new System.Drawing.Size(407, 868);
            this.parserLogicPanel.TabIndex = 1;
            // 
            // parserPanelPlaceholder
            // 
            this.parserPanelPlaceholder.Controls.Add(this.abortButton);
            this.parserPanelPlaceholder.Controls.Add(this.clearButton);
            this.parserPanelPlaceholder.Controls.Add(this.parseButton);
            this.parserPanelPlaceholder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parserPanelPlaceholder.Location = new System.Drawing.Point(25, 802);
            this.parserPanelPlaceholder.Name = "parserPanelPlaceholder";
            this.parserPanelPlaceholder.Size = new System.Drawing.Size(357, 41);
            this.parserPanelPlaceholder.TabIndex = 35;
            // 
            // abortButton
            // 
            this.abortButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.abortButton.Enabled = false;
            this.abortButton.Location = new System.Drawing.Point(207, 0);
            this.abortButton.Name = "abortButton";
            this.abortButton.Padding = new System.Windows.Forms.Padding(5);
            this.abortButton.Size = new System.Drawing.Size(94, 41);
            this.abortButton.TabIndex = 27;
            this.abortButton.Text = "Cancel";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.cancelClick);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(109, 0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Padding = new System.Windows.Forms.Padding(5);
            this.clearButton.Size = new System.Drawing.Size(98, 41);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClick);
            // 
            // parseButton
            // 
            this.parseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.parseButton.Enabled = false;
            this.parseButton.Location = new System.Drawing.Point(0, 0);
            this.parseButton.Name = "parseButton";
            this.parseButton.Padding = new System.Windows.Forms.Padding(5);
            this.parseButton.Size = new System.Drawing.Size(109, 41);
            this.parseButton.TabIndex = 25;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(25, 738);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(357, 25);
            this.progressBar.TabIndex = 33;
            this.progressBar.Visible = false;
            // 
            // emptySpacingLabel2
            // 
            this.emptySpacingLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.emptySpacingLabel2.Location = new System.Drawing.Point(25, 728);
            this.emptySpacingLabel2.Name = "emptySpacingLabel2";
            this.emptySpacingLabel2.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.emptySpacingLabel2.Size = new System.Drawing.Size(357, 10);
            this.emptySpacingLabel2.TabIndex = 32;
            // 
            // parserListView
            // 
            this.parserListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.parserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.wordsColumn,
            this.occurencesColumn});
            this.parserListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.parserListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.parserListView.Location = new System.Drawing.Point(25, 153);
            this.parserListView.Margin = new System.Windows.Forms.Padding(25);
            this.parserListView.MinimumSize = new System.Drawing.Size(70, 4);
            this.parserListView.Name = "parserListView";
            this.parserListView.Size = new System.Drawing.Size(357, 575);
            this.parserListView.TabIndex = 27;
            this.parserListView.UseCompatibleStateImageBehavior = false;
            this.parserListView.View = System.Windows.Forms.View.Details;
            // 
            // wordsColumn
            // 
            this.wordsColumn.Text = "Words";
            this.wordsColumn.Width = 120;
            // 
            // occurencesColumn
            // 
            this.occurencesColumn.Text = "Occurences";
            this.occurencesColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.occurencesColumn.Width = 120;
            // 
            // subtitleParserLabel
            // 
            this.subtitleParserLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtitleParserLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtitleParserLabel.Location = new System.Drawing.Point(25, 25);
            this.subtitleParserLabel.Name = "subtitleParserLabel";
            this.subtitleParserLabel.Padding = new System.Windows.Forms.Padding(35);
            this.subtitleParserLabel.Size = new System.Drawing.Size(357, 128);
            this.subtitleParserLabel.TabIndex = 7;
            this.subtitleParserLabel.Text = "Parser";
            this.subtitleParserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParserFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 868);
            this.Controls.Add(this.parserLogicPanel);
            this.Name = "ParserFunctionForm";
            this.Text = "ParserFunctionForm";
            this.parserLogicPanel.ResumeLayout(false);
            this.parserPanelPlaceholder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel parserLogicPanel;
        private Label subtitleParserLabel;
        private ListView parserListView;
        private ColumnHeader wordsColumn;
        private ColumnHeader occurencesColumn;
        private ProgressBar progressBar;
        private Panel parserPanelPlaceholder;
        private Button abortButton;
        private Button clearButton;
        private Button parseButton;
        private Label emptySpacingLabel2;
    }
}