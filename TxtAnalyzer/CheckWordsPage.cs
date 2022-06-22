using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtAnalyzer
{
    public partial class CheckWordsPage : Form
    {
        public CheckWordsPage()
        {
            InitializeComponent();

            PopulatePage();
        }

        private void insertInDictionary_Click(object sender, EventArgs e)
        {
            String words = wordsNotInDictionary.Text;
            CheckWord.UpdateDictionary(words.ToLower().Split(new string[] { " ", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries));
            this.Close();
        }

        private void PopulatePage()
        {
            String t = null;
            foreach (String str in CheckWord.NotInDictionary)
            {
                if (str == null)
                {
                    break;
                }
                t += str + "\r\n";
            }

            wordsNotInDictionary.Text = t;


            t = null;
            for (int i = 0; i < 257; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (Dictionary.Dict[i, j] != null)
                    {
                        t += Dictionary.Dict[i, j] + "\r\n";
                    }
                }
            }
            wordsInDictionary.Text = t;
        }
    }
}
