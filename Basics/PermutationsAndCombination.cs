using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class PermutationsAndCombination
    {
        List<string> strList = new List<string>();
        public void permute(char[] arry, int i, int n)
        {
            if (i == n)
                Console.WriteLine(arry);
            else
            {
                int j;
                for (j = i; j <= n-1; j++)
                {
                   
                    swap(ref arry[i], ref arry[j]);
                 //   string ss = new string(arry);
                //   strList.Add(ss);
                    permute(arry, i + 1, n);
                    swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
           
        }

        public void swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
