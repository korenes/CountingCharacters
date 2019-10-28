using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)

        {
            string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> countOfLetters = new Dictionary<char, int>();
            foreach (char c in myString)
            {
                if (countOfLetters.ContainsKey(c))
                    countOfLetters[c]++;
                else
                    countOfLetters.Add(c, 1);
            }
            foreach(char c in countOfLetters.Keys)
            {
                Console.WriteLine(c + ":" + countOfLetters[c].ToString());
            }

            
        }
    }
}
