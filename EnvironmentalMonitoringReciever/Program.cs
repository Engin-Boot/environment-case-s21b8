using System;
using System.Collections.Generic;


namespace EnvironmentalMonitoringReciever
{
    abstract class Program
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

            private int _val;
            private void ReadTemperature(string input)
            {
                TemperatureValueChecker value = new TemperatureValueChecker();

                TrimInputToGetValue(input);
                value.Temperature(_val);
            }

            private void TrimInputToGetValue(string input)
            {
                string tmp = input.Split(':')[1].TrimStart();
                try
                {
                    _val = Convert.ToInt32(tmp);
                }
                catch (Exception)
                {
                    Console.WriteLine("Value Not Present");

                }
            }

            private void ReadHumidity(string input)
            {
                HumidityValueChecker value = new HumidityValueChecker();
                TrimInputToGetValue(input);
                value.Humidity(_val);

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
                        rd.ReadHumidity();
                    }
                }
            }

        }
       
    }
}
