using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
       static void Main(string[] args)

       {
           Console.WriteLine("Enter word");
           string str = Console.ReadLine();
           char[] f = str.ToCharArray();
           PermutationsAndCombination pp = new PermutationsAndCombination();
           pp.permute(f,0,f.Length);






           //Console.WriteLine("Difference between const Readonly static");
           //DifferenceBetweenConstReadOnlyStatic dd = new DifferenceBetweenConstReadOnlyStatic();
           



           //Console.WriteLine("Enter how many numbers you want to enter:");
           //int n = Convert.ToInt32(Console.ReadLine());
          
           //MinAndMaxNumbers num = new MinAndMaxNumbers();
           //num.Numbers(n);



           // Console.WriteLine("Enter number");
           // string num = Console.ReadLine();
           //int o;
           //NumberToWords number = new NumberToWords();

           //bool i = int.TryParse(num, out o);

           //if(i) number.ReadNumber(Convert.ToInt32(num));

           //LinearSearch ls = new LinearSearch();
           //ls.MakeList(Convert.ToInt32(num));

           // int i; 
        //var number = int.TryParse(num ,out i);
        //   if (!number)
        //   {
        //       Console.WriteLine("{0} is not number",num);
        //       return;
        //   }

        //   Alphabets alpha = new Alphabets();
        //   string ss = alpha.Number(Convert.ToInt32(num));
           
        //    Console.WriteLine(ss);
            //string words =  Console.ReadLine();

            //RemoveDuplicateCharacters removeDuplicateCharacters = new RemoveDuplicateCharacters();
            //removeDuplicateCharacters.IntakeWords(words);
            Console.ReadLine();
        }
    }
}
