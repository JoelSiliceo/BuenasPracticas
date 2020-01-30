using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class2
    {
        public static void Main2(string[] args)
        {
            int N = 4;// 5;
            int M = 1;//5;
            //int[] X = { 0, 4, 2, 0 };
            int[] X = { 2, 1 };
            //int[] Y = { 0, 0, 1, 4 };
            int[] Y = { 0, 0};

            Console.WriteLine(solution (N,M,X,Y));


            Console.ReadKey();

        }

        public static int solution(int N, int M, int[] X, int[] Y)
        {
            int result = 0;
            int mines1 = 0;
            int mines2 = 0;
            List<Tuple<int, int>> golds = new List<Tuple<int, int>>();
            

            for (int i = 0; i < X.Length; i++)
            {
                golds.Add(Tuple.Create(X[i], Y[i]));
            }

            for (int i = 0; i < N; i++)
            {
                    mines1 = 0;
                    mines2 = 0;
                    foreach (var mine in golds)
                    {
                        if (mine.Item1 <= i ) mines1++;
                        else if (mine.Item1 >= i ) mines2++;
                    }
                if (mines1 > 0 && mines1 == mines2) result++;

            }
            for (int i = 0; i < M; i++)
            {
                mines1 = 0;
                mines2 = 0;
                foreach (var mine in golds)
                {
                    if (mine.Item2 <= i) mines1++;
                    else if (mine.Item2 >= i) mines2++;
                }
                if (mines1 > 0 && mines1 == mines2) result++;

            }

            return result;
        }
    }
}
