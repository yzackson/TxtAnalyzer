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
    public partial class TextPage : Form
    {

        public TextPage()
        {
            InitializeComponent();

            Dictionary.SetDictPath("C:\\Dev\\Faculdade\\TxtAnalyzer\\TxtAnalyzer\\dicionario.txt");
        }

        private void wordsNotInDictionary_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.EndsWith(" ") || textBox.Text.EndsWith("\n"))
            {
                CheckWord.SetAllText(textBox);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openTextFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openTextFile.OpenFile()))
                {
                    textBox.Text = reader.ReadToEnd();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveTextFile.ShowDialog() == DialogResult.OK)
            {
                if (saveTextFile.FileName != "")
                {
                    Stream myStream;

                    myStream = saveTextFile.OpenFile();
                    myStream.Write(Encoding.Default.GetBytes(textBox.Text), 0, textBox.Text.Length);
                    myStream.Close();
                }
            }
        }

        private void openNewDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openTextFile.ShowDialog() == DialogResult.OK)
            {
                if (openTextFile.FileName != "")
                {
                    Dictionary.SetDictPath((String)openTextFile.FileName);
                }
            }
            CheckWord.CheckAllTextInDict();
        }

        private void checkWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckWordsPage checkWordsPage = new CheckWordsPage();
            checkWordsPage.ShowDialog();
        }
    }
}
