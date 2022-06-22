using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtAnalyzer
{
    public class TabelaHash
    {
        int hash;
        public int GetHash(String str)
        {
            int i = str.Length;
            foreach (var c in str)
            {
                this.hash += (int)c * i;
                i--;
            }

            hash = hash / 999;

            return hash;
        }
    }
}
