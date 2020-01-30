using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class3
    {
        public static void Main3(string[] args)
        {
            String[] a = { "bb", "b", "aaa", "ab", "bba" };
            Console.WriteLine(solution(a));


            Console.ReadKey();

        }
        

        public static int solution(String[] words)
        {
            int result = 0;
            Dictionary<char,int> lengths = new Dictionary<char,int>();
            char aux = ' ';
            int maxValue = 0;
            foreach (string word in words)
            {
                aux = ' ';

                foreach (char letter in word)
                {
                    if (aux == letter) maxValue++;
                    else
                    {
                        aux = letter;
                        maxValue = 1;
                    }

                }

                

            }
            return result;
        }
    }
}

