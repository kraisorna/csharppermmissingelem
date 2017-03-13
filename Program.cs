using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] A = { 2,3,1,5 };
            Console.WriteLine(s.solution(A));
            Console.ReadLine();
        }
    }

    class Solution
    {

        public int solution(int[] A)
        {
            if (A.Length == 0)
                return 1;
            var result = A.Length + 1;
            for (int i = 0; i < A.Length; i++)
            {
                result = result ^ (i + 1);
                result = result ^ A[i];
            }
            return result;
        }
    }
}
