using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class1
    {
        public static void Main1(string[] args)
        {
            int[] A = {1,2,3,1,1,4,6,7};

            Console.WriteLine(solucion(A));


            Console.ReadKey();

        }

        public static int solucion(int[] A)
        {
            int result = 1;
            int aux = 0;
            int i = 0;
            if (A.Length == 0 ) return 1;

            Array.Sort(A);
            result = aux = A[0];
             for ( i = 0; i < A.Length; i++)
            {
                // i = i / 2;
                if (A[i] <= 0) continue;
                else
                {
                    if (aux != A[i]) result++;

                    if (result != A[i]) break;
                    aux = A[i];
                }
             }

            if (result <= 0) return 1;
            if (i == A.Length) return A[A.Length - 1] + 1;
            return result;
        }

    }
}
