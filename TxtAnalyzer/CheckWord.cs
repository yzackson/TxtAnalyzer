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
    public static class CheckWord
    {
        private static String[] AllText;
        public static String[] NotInDictionary = new String[1000];

        

        // Set the current text took of the textbox
        public static async Task SetAllText(TextBox text)
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
                CheckWordInDict(AllText[(AllText.Length - 1)]);
            });
        }

        // Check if all the text got from the textbox is in dictionary
        public static async Task CheckAllTextInDict()
        {
            NotInDictionary = new String[1000];

            await Task.Run(() =>
            {
                foreach (string w in AllText)
                {
                    String word = w.ToLower();

                    byte[] c = Encoding.ASCII.GetBytes(word.Substring(0, 1));

                    if(Dictionary.Dict[c[0], Dictionary.TabelaHash.GetHash(word)] == null)
                    {
                        // adiciona na ultima posição 
                        for(int i = 0; i < NotInDictionary.Length; i++)
                        {
                            if (NotInDictionary[i] == null)
                            {
                                NotInDictionary[i] = word;
                                break;
                            }
                        }
                    }
                }
            });
        }

        private static async Task CheckWordInDict(String word)
        {
            await Task.Run(() =>
            {
                word = word.ToLower();

                byte[] c = Encoding.ASCII.GetBytes(word.Substring(0, 1));

                if (Dictionary.Dict[c[0], Dictionary.TabelaHash.GetHash(word)] == null)
                {
                    // adiciona na ultima posição 
                    for (int i = 0; i < NotInDictionary.Length; i++)
                    {
                        if (NotInDictionary[i] == null)
                        {
                            NotInDictionary[i] = word;
                            break;
                        }
                    }
                }
            });
        }


        public static void UpdateDictionary(String[] NewDictionary)
        {
            for (int i = 0; i < NewDictionary.Length; i++)
            {
                if (NotInDictionary[i] != null)
                {
                    //Dictionary.Add(word.ToLower(), true);
                    String word = NotInDictionary[i].ToLower();

                    byte[] c = Encoding.ASCII.GetBytes(word.Substring(0, 1));

                    Dictionary.Dict[c[0], Dictionary.TabelaHash.GetHash(word)] = word;

                    NotInDictionary[i] = null;
                }
                else
                {
                    break;
                }
            }

            Dictionary.SaveDictionary();
        }
    }
}
