using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class RemoveDuplicateCharacters
    {
        List<char> _characterList = new List<char>();
    //    private r;
        // Accept string
        public void IntakeWords(string words)
        {
            string str= "";
            foreach (var word in words)
            {
                if (str.IndexOf(word) == -1)
                    str += word;
            }
            Console.WriteLine(str);
        }
        // Stores in a list
        // check

        
    }

}
