using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Parser.View;
using System.Reflection;

namespace Parser
{
    public partial class MainParserForm : Form
    {
        //  A single entry point class for client/view/frontend entities to have access to
        //  Business Service methods.

        private ParserFunctionForm _parserLogicForm;
        private AboutForm _aboutForm;


        private Controller _controller;
  
        public MainParserForm(Controller controller)
        {

            InitializeComponent();
            this._controller = controller;
            this.DoubleBuffered= true;
            this._aboutForm = _aboutForm = new AboutForm();
            this._parserLogicForm = new ParserFunctionForm(this._controller,
                                                       this.openFileDialog1,
                                                       this.fileNameLabel,
                                                       this.statusLabel);
            ButtonActive(this.parserButton);
            OpenSubForm(_parserLogicForm);


        }

        private void LoadButtonClick(object sender, EventArgs e)
        {
            _parserLogicForm.LoadButtonClick(sender, e);

        }

        private void OpenSubForm(Form subform)
        {

            subform.TopLevel = false;
            this.mainWorkPanel.Tag = subform;
            this.mainWorkPanel.Controls.Add(subform);
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            subform.BringToFront();
            subform.Show();

        }


        private void ParserButtonClick(object sender, EventArgs e)
        {
            ButtonActive(sender);
            OpenSubForm(_parserLogicForm);

        }
        private void AboutButtonClick(object sender, EventArgs e)
        {

            ButtonActive(sender);
            OpenSubForm(_aboutForm);



        }



        private void ButtonActive(object buttonValue) {

            ButtonInactive();
            if (buttonValue != null)
            {
                if (currrent_button != buttonValue)
                {
                    currrent_button =(System.Windows.Forms.Button) buttonValue;
                    currrent_button.BackColor = Color.FromArgb(234,234,234);


                }
            }
        }
        private void ButtonInactive()
        {
            foreach (Control prev_btn in menuPanel.Controls)
            {
                if (prev_btn.GetType() == typeof(System.Windows.Forms.Button))
                {
                    prev_btn.BackColor = Color.White;

                }
            }
        
        }





    }
}