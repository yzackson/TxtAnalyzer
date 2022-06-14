using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtAnalyzer
{
    public partial class Form1 : Form
    {
        //private String[] originalText = null;
        internal Hashtable _dictionary = new Hashtable();
        CheckWord CheckWord = new CheckWord();

        public Form1()
        {
            InitializeComponent();

            CheckWord.GetNewDict += CheckWord.UpdateDictionary;

            CheckWord.SetDictPath(@"C:\Dev\Faculdade\TxtAnalyzer\TxtAnalyzer\dicionario.txt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.EndsWith(" ") || textBox.Text.EndsWith("\n"))
            {
                CheckWord.SetAllText(textBox);
            }
        }
    }
}
