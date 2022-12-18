using System.Collections;
using System.IO;

namespace Parser
{
    public class Model
    {
        private string _separationCharacter = " ";
        private string? _filePath;
        private StreamReader? _streamReader;

        Dictionary<string, int> _wordOccurencePair = new Dictionary<string, int>();
        public void SetSeparationCharacter(string character)
        {
            _separationCharacter = character;
        }

        ~Model()
        {

            if (_streamReader != null)
            {
                _streamReader.Dispose();
            }
        }


        // Parses and sorts the model loaded text file.
        // parameter: none
        // returns: a sorted dictionary or null
        internal Dictionary<string, int> Parse()
        {
            try
            {
                if (_streamReader != null)
                {
                    string? readLine = "";

                    if ((readLine = _streamReader.ReadLine()) == null)
                    {
                        return _wordOccurencePair;
                    }
                    else {
                        ReloadStream();
                    }
                    while ((readLine = _streamReader.ReadLine()) != null)
                    {
                        string[] words = readLine.Split(_separationCharacter);
                        foreach (var word in words)
                        {
                            if (word == "") continue;
                            if (_wordOccurencePair.ContainsKey(word))
                            {
                                _wordOccurencePair[word] += 1;
                            }
                            else
                            {
                                _wordOccurencePair.Add(word, 1);
                            }
                        }
                    }

                    return _wordOccurencePair;




                }
                else
                {
                    MessageBox.Show($"A text file should be loaded first.\n");
                    throw new Exception("Streamreader is null");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                return _wordOccurencePair;
            }


        }

        // Clear model dictionary used in parsing
        internal void ClearContents()
        {
            _wordOccurencePair.Clear();
            _streamReader?.Dispose();

        }
        internal void ReloadStream()
        {
            if (_filePath == null)
            {
                throw new Exception("File path is null. You must load a file first.");

            }
            if (_streamReader != null)
            {
                _streamReader.Dispose();
                _streamReader = new StreamReader(this._filePath);
            }

        }
            // Loads file
            // parameter: file path
            // returns: stream reader
            internal void LoadFile(string file_path)
        {
            this._filePath = file_path;
            ClearContents();
            try
            {
                if (_streamReader != null)
                {
                    _streamReader.Dispose();
                    _streamReader = new StreamReader(file_path);
                }
                else
                {

                    _streamReader = new StreamReader(file_path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
            }
        }
    }
}