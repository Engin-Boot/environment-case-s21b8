using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace EnvironmentalMonitoringReciever
{
    class Program
    {
        static List<string> inputvalues = new List<string>();

        static void Main(string[] args)
        {
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                inputvalues.Add(s);
            }
            ReadConsoleOutput rd = new ReadConsoleOutput();
            rd.ParseInputList();

        }

        public class ReadConsoleOutput
        {

            public int val;
            internal void temperatureread(string input)
            {
                string tmp = input.Split(':')[1].TrimStart();
                val = Convert.ToInt32(tmp);
                TemperatureValueChecker value = new TemperatureValueChecker();
                 value.Temperature(val);
                

            }
            internal void humidityread(string input)
            {
                string tmp = input.Split(':')[1].TrimStart();
                val = Convert.ToInt32(tmp);
                HumidityValueChecker value = new HumidityValueChecker();
                value.Humidity(val);

            }
            public void ParseInputList()
            {
                foreach (var input in inputvalues)
                {
                    if (input.StartsWith("Temperature"))
                    {
                        ReadConsoleOutput rd = new ReadConsoleOutput();
                        rd.temperatureread(input);
                    }
                    if (input.StartsWith("Humidity"))
                    {
                        ReadConsoleOutput rd = new ReadConsoleOutput();
                        rd.humidityread(input);
                    }
                }
            }

        }
       
    }
}
