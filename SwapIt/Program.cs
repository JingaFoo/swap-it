using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SwapIt grabs the first and last characters of a word and swaps them");
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if(word.Length > 1)
            {
                Console.WriteLine("Your new word is: {0}", word.Substring(word.Length - 1) + word.Substring(1, word.Length - 2) + word.Substring(0, 1));
            } else
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
