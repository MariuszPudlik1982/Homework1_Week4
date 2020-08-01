using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var getCheckValue = new UserCommnicator();
            var number=getCheckValue.CheckIfNumber();
            var oddEven=new CheckerOfOddEven();
            Console.WriteLine(oddEven.GetInfo(oddEven.CheckOddEven(number)));
            Console.ReadKey();
        }
    }
}
