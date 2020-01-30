using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class5
    {
        public static void Main5(string[] args)
        {
            String a =  "Mary" ;
            String b =  "Armyy" ;
            Console.WriteLine(solution(a, b));


            Console.ReadKey();

        }

        //Anagram
        public static bool solution(String word1, String word2)
        {
            //if (word1.Length != word2.Length) return false;

            foreach (char c in word2.ToUpper().ToCharArray())
            {
                if (!word1.ToUpper().Contains(c))
                {
                    return false;
                }

                word1 =  word1.ToUpper().Remove(word1.ToUpper().IndexOf(c));
            }

            return true;
        }
    }
}
