using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
   public class DifferenceBetweenConstReadOnlyStatic
   {
       private int count = 0;
       private readonly int counter = 4;
       private const int counters = 7;
       private static int c = 6;
        public DifferenceBetweenConstReadOnlyStatic()
        {
            count++;
            counter++;
           // counters++;
            c++;
        }

       public void ff()
       {
           count++;
          // counter++;
           // counters++;
           c++; 

       }

       public void fg()
       {
           count++;
      //   counter = counter++;
           // counters++;
         c =  c++;
       }
    }
}
