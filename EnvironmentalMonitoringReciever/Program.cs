using System;
using System.Collections.Generic;


namespace EnvironmentalMonitoringReciever
{
    class Program
    {
        private static readonly List<string> InputValues = new List<string>();

        static void Main()
        {
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                InputValues.Add(s);
            }
            ReadConsoleOutput rd = new ReadConsoleOutput();
            rd.ParseInputList();

        }

        private class ReadConsoleOutput
        {

            private int Val;
            private void ReadTemperature(string input)
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
            private void ReadHumidity(string input)
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
                foreach (var input in InputValues)
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
