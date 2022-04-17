using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppFileRazbor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countLettersInAlphabet = 32;
            char[] findLetters = new char[countLettersInAlphabet];
            int[] countFindLetters = new int[countLettersInAlphabet];

            char currentSymb = 'а';
            for (int i = 0; i < findLetters.Length; i++)
            {
                findLetters[i] = currentSymb;
                currentSymb++;
            }

            for (int i = 0; i < countFindLetters.Length; i++)
            {
                countFindLetters[i] = 0;
            }

            string text = File.ReadAllText("input.kst");


            for (int i = 0; i < findLetters.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if(text[j] == findLetters[i])
                    {
                        countFindLetters[i]++;
                    }
                }
            }
            
            Console.WriteLine($"Исходный текст = \n{text}");

            for (int i = 0; i < countLettersInAlphabet; i++)
            {
                Console.WriteLine($"Количество найденных букв {findLetters[i]} = {countFindLetters[i]}, {countFindLetters[i]/(double)text.Length*100}%");
            }
            

            Console.ReadKey();
        }
    }
}
