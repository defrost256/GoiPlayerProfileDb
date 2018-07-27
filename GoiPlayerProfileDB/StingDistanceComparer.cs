using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoiPlayerProfileDB
{
    public class StingDistanceComparer
    {
        public static int Levenshtein(string a, string b)
        {
            int la = a.Length;
            int lb = b.Length;
            int[,] lines = new int[2, lb + 1];
            int baseLine = 0;
            int nextLine = 1;
            for(int i = 0; i <= lb; i++)
            {
                lines[0, i] = i;
            }
            for(int i = 0; i < la; i++)
            {
                lines[nextLine, 0] = i + 1;

                for(int j = 0; j < lb; j++)
                {
                    int delCost = lines[baseLine, j + 1] + 1;
                    int insCost = lines[nextLine, j] + 1;
                    int subCost = 0;
                    if(a[i] == b[j])
                    {
                        subCost = lines[baseLine, j];
                    }
                    else
                    {
                        subCost = lines[baseLine, j] + 1;
                    }
                    lines[nextLine, j + 1] = Math.Min(delCost, Math.Min(insCost, subCost));
                }

                baseLine = nextLine;
                nextLine = (nextLine == 0 ? 1 : 0);
            }
            return lines[baseLine, lb];
        }

        public static int LeveshteinImproved(string a, string b)
        {
            throw new NotImplementedException();
        }

        public static int Hamming(string a, string b)
        {
            throw new NotImplementedException();
        }
    }
}
