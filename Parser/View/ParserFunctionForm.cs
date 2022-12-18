using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser.View
{
    public partial class ParserFunctionForm : Form
    {
        public ParserFunctionForm(Controller controller, OpenFileDialog openFileDialog1, Label file_name_label, Label StatusLabel)
        {
            this.DoubleBuffered = true;
            this.ControlBox = false;

            this._controller = controller;
            this._statusLabel = StatusLabel;
            this.openFileDialog = openFileDialog1;
            InitializeComponent();
            this._fileNameLabel = file_name_label;
        }


        private CancellationTokenSource? _parseTextTokenSource;
        private CancellationToken _parseTextCToken;

        private string _statusText = "Status: ";
        private string _fileNameLabelText = "Filename: ";

        private Controller _controller;
        private OpenFileDialog openFileDialog;
        private Label _fileNameLabel;
        private Label _statusLabel;
        private void HandleEventLoad() {

            this.parseButton.Enabled = true;
            this._statusLabel.Text = _statusText + "File Loaded";
            this.abortButton.Enabled = false;
            _fileNameLabel.Text = _fileNameLabelText + openFileDialog.SafeFileName;
        }
        private void HandleEventParse()
        {
            this.Invoke(new MethodInvoker(delegate () {
                this.progressBar.Visible = true;
                this._statusLabel.Text = _statusText + "Parsing File...";
                this.abortButton.Enabled = true;
            }));

        }

        private void HandleEventInsertToListIncremental(string word, string occurence, 
            ListViewItem[] list_view_item_array, int count_items_in_list) {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                             word,
                             occurence}, -1);
            
            list_view_item_array[count_items_in_list] = listViewItem1;




        }

        private void HandleEventInsertToListNonIncremental(string word, string occurence,
    ListViewItem[] list_view_item_array, int count_items_in_list)
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                             word,
                             occurence}, -1);
            list_view_item_array[count_items_in_list] = listViewItem1;

        }

        public void LoadButtonClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearList();
                _controller.LoadFile(openFileDialog.FileName);
                HandleEventLoad();
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {

            this.progressBar.Value = 0;

            _parseTextTokenSource = new CancellationTokenSource();
            _parseTextCToken = _parseTextTokenSource.Token;
            /* Create a task here because I expect reading the file to take a while
            This goes with the assumption that file sizes and reading will block the 
            main/render thread.
             */

            Task dispatch_parsefile = Task.Factory.StartNew(() =>
            {

                // enable progress bar and Cancel/abort Button
                HandleEventParse();

                // Handle parsing
                var outputParseValue = _controller.ParseText();
 
                // Array created to link to List view items so that they can be added in bulk without 
                // constantly calling the renderer
                int arraySize = outputParseValue.Count;
                bool incrrementalUpdates = false;
                int textSize = 10000;

                ListViewItem[] listViewItemsArray = new System.Windows.Forms.ListViewItem[arraySize];
                ListViewItem[] tempListArray = new System.Windows.Forms.ListViewItem[textSize];

                int countItemsIntoList = 0;
                if (outputParseValue.Count > textSize)
                {
                    incrrementalUpdates = false;
                }

                int tempCounter = 0;
                foreach (KeyValuePair<string, int> pair in outputParseValue.OrderByDescending(key => key.Value))
                {

                    _parseTextCToken.ThrowIfCancellationRequested();

                    var word = pair.Key;
                    var occurence = pair.Value.ToString();
                    HandleProgesBar(outputParseValue.Count, countItemsIntoList);


                    if (incrrementalUpdates)
                    {
                        if (tempCounter != textSize)
                        {
                            HandleEventInsertToListIncremental(word, occurence,
                                                                tempListArray,
                                                                tempCounter
                                                                );
                            tempCounter++;
                        }
                        else {
                            this.Invoke(new MethodInvoker(delegate () {
                                this.parserListView.Items.AddRange(tempListArray);

                            }));
                            tempListArray = new System.Windows.Forms.ListViewItem[textSize];
                            tempCounter = 0;
                        }
                    }
                    else {
                        HandleEventInsertToListNonIncremental(word, occurence,
                                                listViewItemsArray,
                                                countItemsIntoList);

                    }


                    countItemsIntoList++;


                }
                _controller.ClearModel();
                if (!incrrementalUpdates) {
                    HandleEventEndParseNonIncremental(listViewItemsArray);
                }
                else{
                    HandleEventEndParseIncremental();
                }
                _parseTextTokenSource.Dispose();
                _parseTextTokenSource = null;
 
            }, _parseTextCToken);


        }

        private void HandleProgesBar(int output_parse_value,int count_items_in_list)
        {
            this.Invoke(new MethodInvoker(delegate () {
                this.progressBar.Minimum = 0;
                this.progressBar.Maximum = output_parse_value - 1;
                this.progressBar.Value = count_items_in_list;
            }));
        }

        private void HandleEventEndParseIncremental()
        {
            this.Invoke(new MethodInvoker(delegate () {
                this.parseButton.Enabled = false;
                this.progressBar.Visible = false;
                this.clearButton.Enabled = true;
                this._statusLabel.Text = _statusText + "Parsed";
                this.abortButton.Enabled = false;
            }));

        }
        private void HandleEventEndParseNonIncremental(ListViewItem[] listViewItemArray)
        {
            this.Invoke(new MethodInvoker(delegate () {
                this.parseButton.Enabled = false;
                this.parserListView.Items.AddRange(listViewItemArray);
                listViewItemArray = new System.Windows.Forms.ListViewItem[0];

                this.progressBar.Visible = false;
                this.clearButton.Enabled = true;
                this._statusLabel.Text = _statusText + "Parsed";
                this.abortButton.Enabled = false;
            }));

        }

        private void cancelClick(object sender, EventArgs e)
        {
            this.progressBar.Visible = false;
            this.parseButton.Enabled = true;
            this.progressBar.Value = 0;


            if (_parseTextTokenSource != null)
            {
                _parseTextTokenSource.Cancel();

                this.abortButton.Enabled = false;
                this._statusLabel.Text = _statusText + "Canceled";
            }


        }
        // known bug, lags when clearing a large list
        private void ClearList()
        {
            _controller.ClearModel();
            this.parserListView.Items.Clear();
            this.clearButton.Enabled = false;
        }

        private void ClearClick(object sender, EventArgs e)
        {
            ClearList();
            _fileNameLabel.Text = _fileNameLabelText;
            this._statusLabel.Text = _statusText + "Cleared";
    
        }





    }
}
