using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class4
    {
        public static void Main4(string[] args)
        {
            int[] a = { 6,1,4,6,3,2,7,4 };
            //int[] a = { 10,19,15 };
            Console.WriteLine(solution(a,3,2));
            
            Console.ReadKey();
        }

        public static int solution(int[] A, int k, int l)
        {
            int sum1 = 0;
            int aux1 = 0;
            int sum2 = 0;
            int aux2 = 0;
            List<int> positions1 = new List<int>();

            if (k < l)
            {
                int aux = k;
                k = l;
                l = aux;
            }
                for (int i = 0;i<A.Length; i++)
                {
                    sum1 = 0;
                    if (i + k < A.Length + 1){
                        for (int j = i; j < i+k; j++)
                        {

                            
                            sum1 += A[j];
                        }
                    }


                if (aux1 == 0 || sum1 > aux1)
                {
                    aux1 = sum1;
                    positions1.Clear();
                    for (int j = i; j < i + k; j++) positions1.Add(j);
                }
                
                }
                for (int i = 0; i < A.Length; i++)
                {
                    sum2 = 0;
                    if (i + l < A.Length + 1)
                    {
                        for (int j = i; j < i + l ; j++)
                        {

                        if (!positions1.Contains(j)) sum2 += A[j];
                        else
                        {
                            sum2 = 0;
                            break;
                        }
                        }
                    }


                    if (aux2 == 0 || sum2 > aux2) aux2 = sum2;
                }


            if (aux1 == 0 || aux2 == 0) return -1;
            return aux1 + aux2;
        }

    }
}
