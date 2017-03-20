using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class LinearSearch
    {
        //1. int array list
        //2. search in the list
        //3.
        public void MakeList(int numberToFind)
        {
            int[] array = {1,2,3,4};
            SerachNumber(array, numberToFind);
        }

        private void SerachNumber(int[] array, int numberToFind)
        {
            if (!array.Contains(numberToFind))
                Console.WriteLine("{0} number doestnot exist",numberToFind);

            else
                PositionOfNumber(array, numberToFind);
            
        }

        private void PositionOfNumber(int[] array, int numberToFind)
        {
            for (int count = 0; count <= array.Length - 1; count++)
            {
                if (array[count] == numberToFind)
                {
                    Console.WriteLine("{0} is present at {1} location",numberToFind, count+1);
                }
            }
        }
    }
}
