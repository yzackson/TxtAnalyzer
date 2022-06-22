using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtAnalyzer
{
    public static class Dictionary
    {

        public static String DictPath;
        public static TabelaHash TabelaHash = new TabelaHash();
        public static String[,] Dict = new String[257, 1000];


        // set path to new dict
        public static async void SetDictPath(String path)
        {
            await Task.Run(() =>
            {
                if (DictPath != path)
                {
                    DictPath = path;
                }
            }).ContinueWith(t => OpenNewDictionary(null, null));
        }



        // Import new dictionary
        public static async Task OpenNewDictionary(object sender, EventArgs e)
        {
            String _dict = "";

            if (!File.Exists(DictPath))
            {
                await Task.Run(() =>
                {
                    FileStream fs = File.Create(DictPath);
                    fs.Close();
                }).ContinueWith(t =>
                {
                    _dict = File.ReadAllText(DictPath, Encoding.UTF8);
                });
            } else
            {
                _dict = File.ReadAllText(DictPath, Encoding.UTF8);
            }

            if (!(_dict == null || _dict == ""))
            {
                foreach (string w in _dict.Split(','))
                {
                    //Dictionary.Add(word.ToLower(), true);
                    String word = w.ToLower();

                    byte[] c = Encoding.ASCII.GetBytes(word.Substring(0, 1));

                    Dict[c[0], TabelaHash.GetHash(word)] = word;
                }
            }
        }


        public static void SaveDictionary()
        {
            var saveTextFile = new System.Windows.Forms.SaveFileDialog();
            saveTextFile.FileName = "*.txt";
            saveTextFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveTextFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveTextFile.FileName != "")
                {
                    String DictText = "";

                    for (int i = 0; i < 257; i++)
                    {
                        for (int j = 0; j < 1000; j++)
                        {
                            if (Dict[i, j] != null)
                            {
                                DictText += Dict[i, j] + ",";
                            }
                        }
                    }

                    Stream myStream;
                    
                    myStream = saveTextFile.OpenFile();
                    myStream.Write(Encoding.Default.GetBytes(DictText), 0, DictText.Length);
                    myStream.Close();

                    SetDictPath((String)saveTextFile.FileName);
                }
            }

            
        }
    }
}
