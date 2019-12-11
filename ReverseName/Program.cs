using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name to reverse");
            var input = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input))
            {
                var stringArr = new char[input.Length];
                for (int i = 0; i < stringArr.Length; i++)
                {
                    stringArr[i] = input[i];
                }

                var reversedArr = stringArr.Reverse();
                var returnString = String.Join("", reversedArr);
                Console.WriteLine(returnString);
            }
        }
    }
}
