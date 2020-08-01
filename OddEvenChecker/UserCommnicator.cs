using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    public class UserCommnicator
    {
       public double CheckIfNumber()
        {
            double number;
            bool succed;
            string value;
            do
            {
                Console.WriteLine("Podaj liczbę rzeczywistą");
                value = Console.ReadLine();
               
                    if (value == null)
                    {
                    throw new Exception("Podałeś nula");
                    }
    
                succed = Double.TryParse(value, out number);
            } while (!succed);
            return number;
        }
    }
}
        
