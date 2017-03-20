using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
  public  class MinAndMaxNumbers
    {
      List<int> numList = new List<int>();
        public void Numbers(int numberCount)
        {
            Console.WriteLine("You Entered {0}",numberCount);
            GetNumbers(numberCount);
            DisplayNumbers();
            SortNumbers();
            DispalySortedNumbers();
        }

        private void DispalySortedNumbers()
        {
         numList.ForEach(Console.WriteLine);
         //   Console.ReadLine();
        }

        private void SortNumbers()
        {
         //  numList.Sort();
            int a;
            for (int count = 0; count <= numList.Count -1 ; count++)
            {
                for (int index =count+1; index <=numList.Count-1  ; index++)
                {
                    if (numList[count] > numList[index])
                    {
                        a = numList[count];
                        numList[count] = numList[index];
                        numList[index] = a;
                    }
                }
            }
        }

        private void GetNumbers(int numberCount)
        {
            for (int count = 0; count <= numberCount - 1; count++)
            {
                Console.WriteLine("Enter number[{0}] number",count);
                int number = Convert.ToInt32(Console.ReadLine());
                numList.Add(number);
            }
        }

        private void DisplayNumbers()
        {
            foreach (var number in numList)
            {
                Console.WriteLine(number +"\n");
            }
        }
    }
}
