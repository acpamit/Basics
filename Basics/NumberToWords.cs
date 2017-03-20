using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    class NumberToWords
    {
        Dictionary<int, string> numberValues = new Dictionary<int, string>();
        string str = "";
        //   Dictionary<int,int> tets = new Dictionary<int, int>();
        public void ReadNumber(int number)
        {
            ReadNumberValue();
            Console.WriteLine("You enter {0}", number);
            do
            {
                int num = number % 10;
                var result = numberValues.FirstOrDefault(x => x.Key == num).Key;
                var value = numberValues.FirstOrDefault(x => x.Key == result).Value;
                str += " " + Convert.ToString(value);
                number = number / 10;
            } while (number > 0);

            string reverseWords =String.Join(" ",str.Split(' ').Reverse());
                       
            Console.WriteLine("{0}", reverseWords);
            Console.ReadLine();
        }

        private void ReadNumberValue()
        {
            numberValues.Add(0, "Zero");
            numberValues.Add(1, "one");
            numberValues.Add(2, "two");
            numberValues.Add(3, "three");
            numberValues.Add(4, "four");
            numberValues.Add(5, "five");
            numberValues.Add(6, "six");
            numberValues.Add(7, "seven");
            numberValues.Add(8, "eight");
            numberValues.Add(9, "nine");
        }

    }
}
