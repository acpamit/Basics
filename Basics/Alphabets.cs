using System.Text;

namespace Basics
{
    class Alphabets
    {
        private const int AsciiValue = 065;
      

        public string Number(int number)
        {
            StringBuilder result = new StringBuilder();

            Generator(number, result);
           
            return result.ToString();
        }

        private int Generator(int number, StringBuilder result)
        {
            if (number <= 0) return number > 0 ? Generator(number, result) : number;

            int lowChar = (number - 1) % 26;
            number = (number - 1) / 26;
            result.Insert(0, (char) (lowChar + AsciiValue));
            return number > 0  ?  Generator(number, result) : number;
        }
    }
}
