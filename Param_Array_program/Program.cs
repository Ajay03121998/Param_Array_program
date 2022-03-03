using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param_Array_program
{
    internal class ParamsArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ParamsArray app = new ParamsArray();
            int sum = app.AddElements(10, 20, 30, 40, 50);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
