using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace EnvironmentalMonitoringReciever
{
    class Program
    {
        static List<string> inputvalues=new List<string>();
        
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
                string tmp=input.Split(':')[1].TrimStart();
                
                if ((tmp.Equals(Convert.ToInt32(tmp))))
                {
                    Console.WriteLine("Value Not Present");
                }
                else
                {
                    
                    ValueChecker value = new ValueChecker();
                    value.Temperature(val);
                }
                
            }
            internal void humidityread(string input)
            {
                string tmp = input.Split(':')[1].TrimStart();
                val = Convert.ToInt32(tmp);
                ValueChecker value = new ValueChecker();
                value.Humidity(val);

            }
            public void ParseInputList()
            {
                foreach(var input in inputvalues)
                {
                    if(input.StartsWith("Temperature"))
                    {
                        ReadConsoleOutput rd = new ReadConsoleOutput();
                        rd.temperatureread(input);
                    }
                    if(input.StartsWith("Humidity"))
                    {
                        ReadConsoleOutput rd = new ReadConsoleOutput();
                        rd.humidityread(input);
                    }
                }
            }

        }
        //public class Receiver
        //{
        //    public readonly StreamReader input;
        //    public readonly StreamWriter output;
        //    //public Receiver() : this(Console.In, Console.Out)
        //    //{

        //    //}
        //    public Receiver(StreamReader input, StreamWriter output)
        //    {
        //        this.input = input;
        //        this.output = output;
        //    }

            
        //}
            //private TextWriter stdOutWriter;
            //public TextWriter Captured { get; private set; }
            //public void OutputCapture()
            //{

            //    this.stdOutWriter = Console.Out;
            //    Console.SetOut(this);
            //    Captured = new StringWriter();
            //}

            //public class OutputCapture : TextWriter, IDisposable
            //{
            //    private TextWriter stdOutWriter;
            //    public TextWriter Captured { get; private set; }
            //    public override Encoding Encoding { get { return Encoding.ASCII; } }

            //    public OutputCapture()
            //    {
            //        this.stdOutWriter = Console.Out;
            //        Console.SetOut(this);
            //        Captured = new StringWriter();
            //    }

            //    override public void Write(string output)
            //    {

            //        Captured.Write(output);
            //        stdOutWriter.Write(output);
            //    }

            //    override public void WriteLine(string output)
            //    {

            //        Captured.WriteLine(output);
            //        stdOutWriter.WriteLine(output);
            //    }


            //}
        }
}
