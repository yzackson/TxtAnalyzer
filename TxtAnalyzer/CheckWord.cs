using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtAnalyzer
{
    class CheckWord
    {
        private String[] AllText;
        private Hashtable Dictionary = new Hashtable();
        public String DictPath;

        // Event to get new dict
        public event EventHandler<String> GetNewDict;

        // set path to new
        public void SetDictPath(String path)
        {
            if (DictPath != path)
            {
                DictPath = path;
                OnDictPathChenged();
            }
        }

        // Method to be called when path change
        protected virtual void OnDictPathChenged()
        {
            GetNewDict?.Invoke(this, this.DictPath);
        }

        // Import new dictionary
        public void UpdateDictionary(object sender, String path)
        {
            String _dict = File.ReadAllText(path, Encoding.UTF8);
            foreach (string word in _dict.Split(','))
            {
                Dictionary.Add(word.ToLower(), true);
            }
        }

        // Set the current text took of the textbox
        public async Task SetAllText(TextBox text)
        {
            Task<String[]> Text = Task.Run(() =>
            {
                return text.Text
                    .ToLower()
                    .Split(new string[] { " ", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            });

            await Text.ContinueWith(t =>
            {
                AllText = t.Result;
                CheckAllTextInDict();
            });
        }

        // Check if all the text got of the textbox is in dictionary
        private async Task CheckAllTextInDict()
        {
            await Task.Run(() =>
            {
                foreach (String word in AllText)
                {
                    if (!Dictionary.Contains(word))
                    {
                        Dictionary.Add(word, false);
                    }
                }
            });
        }
    }
}
