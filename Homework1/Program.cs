using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "acdemy";
            bool founder = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    founder = true;
                }
               
            }
            if (founder==true)
            {
                Console.WriteLine("a letter is into word");
            }
            else
            {
                Console.WriteLine("a letter is not into word");
            }
        }
    }
}
