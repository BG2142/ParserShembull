using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;



namespace Parser
{
    public class Controller
    {
        private Model _model;

        public Controller(Model model)
        {
            this._model = model;
        }

        // text parser, retturns a sorted Dictionary by value.
        // sorting is from highest to lowest occurence or descending order
        // in case of errors, returns an empty Dictionary

        internal Dictionary<string, int> ParseText()
        {
            return _model.Parse();
        }

        // read file from file_path
        // returns string
        internal void LoadFile(string filePath)
        {
            _model.LoadFile(filePath);
        }
        internal void ClearModel()
        {
            _model.ClearContents();
        }


    }
}