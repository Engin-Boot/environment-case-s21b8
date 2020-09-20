using System;
using System.Collections.Generic;


namespace EnvironmentalMonitoringReciever
{
    class Program
    {
        private static readonly List<string> Inputvalues = new List<string>();

        static void Main()
        {
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                Inputvalues.Add(s);
            }
            ReadConsoleOutput rd = new ReadConsoleOutput();
            rd.ParseInputList();

        }

        public class ReadConsoleOutput
        {

            public int Val;
            internal void ReadTemperature(string input)
            {
                string tmp = input.Split(':')[1].TrimStart();
                try
                {
                    Val = Convert.ToInt32(tmp);
                }
                catch (Exception)
                {
                    Console.WriteLine("Value Not Present");
                    
                }
                
                TemperatureValueChecker value = new TemperatureValueChecker();
                 value.Temperature(Val);
                

            }
            internal void ReadHumidity(string input)
            {
                string tmp = input.Split(':')[1].TrimStart();
                try
                {
                    Val = Convert.ToInt32(tmp);
                }
                catch (Exception)
                {
                    Console.WriteLine("Value Not Present");

                }
                HumidityValueChecker value = new HumidityValueChecker();
                value.Humidity(Val);

            }
            public void ParseInputList()
            {
                foreach (var input in Inputvalues)
                {
                    if (input.StartsWith("Temperature"))
                    {
                        ReadConsoleOutput rd = new ReadConsoleOutput();
                        rd.ReadTemperature(input);
                    }
                    if (input.StartsWith("Humidity"))
                    {
                        ReadConsoleOutput rd = new ReadConsoleOutput();
                        rd.ReadHumidity(input);
                    }
                }
            }

        }
       
    }
}
