using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provEmil2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1;2;3;4;5;6;7;8;9;10;11;12";
            int[] ia = tointarray(s1, ';');
        }
        int[] tointarray(string value, char sep)
        {
            string[] sa = value.Split(sep);
            int[] ia = new int[sa.Length];
            for (int i = 0; i < ia.Length; ++i)
            {
                int j;
                string s = sa[i];
                if (int.TryParse(s, out j))
                {
                    ia[i] = j;
                }
            }
            return ia;
        }
    }
}
