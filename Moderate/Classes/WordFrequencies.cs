using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Moderate
{
    class WordFrequencies
    {

        private static Hashtable FreqencyHash = new Hashtable();
        public static void CalculateNumberOfOccurencesOfAWordInBook()
        {
            //Disabled 
            //Console.WriteLine("Please Enter Path where the book is located");
            //string path = Console.ReadLine();
            //if (!File.Exists(path))
            //{
            //    Console.WriteLine("Path is invalid");
            //    Console.Read();
            //    return;
            //}
            string contentOfBook = Resources.LargeTextFile;

            while (true)
            {
                Console.WriteLine("Please enter the word you want to Find");
                string findWord = Console.ReadLine().Trim();

                foreach (string word in contentOfBook.Split(' '))
                {
                    if (FreqencyHash.ContainsKey(word))
                        FreqencyHash[word] = int.Parse(FreqencyHash[word].ToString()) + 1;
                    else
                        FreqencyHash.Add(word, 1);
                }
                if (FreqencyHash.ContainsKey(findWord))
                    Console.WriteLine($"\r\n Frequency of the Word {findWord} is : " + FreqencyHash[findWord].ToString());
                else
                    Console.WriteLine($"\r\n Cannot Find word {findWord}");
                Console.Write("Do you want to Continue y/n?");
                if (Console.ReadLine() == "y") continue;
                else
                    break;
            }
            Console.ReadLine();
        }
    }
}
