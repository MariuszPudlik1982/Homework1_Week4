using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    public class CheckerOfOddEven
    {
       public bool CheckOddEven(double number)
       {
            double result;
            bool even=false;
            result = number % 2;
            if (result==0)
            {
                even = true;              
            }
            else
            {
                even = false;
            }
            return even;
       }
        public string GetInfo(bool CheckOddEven)
        {
            if (CheckOddEven==true)
            {
                return "liczba parzysta";
            }
            else
            {
                return "liczba nieparzysta";
            }
        }
    }
}
