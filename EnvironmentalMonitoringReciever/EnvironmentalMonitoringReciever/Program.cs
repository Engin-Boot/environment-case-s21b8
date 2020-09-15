using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO;

namespace EnvironmentalMonitoringReciever
{
    class Program
    {
       

        static void Main(string[] args)
        {
           
            ValueChecker valueChecker = new ValueChecker();
            Console.Write("Enter Integer: ");
            string val = Console.ReadLine();
            int a = Convert.ToInt32(val);
            Console.WriteLine("Your input: {0}", a);

            
            valueChecker.Temperature(a);
            valueChecker.Humidity(a);



        }
    }
}
