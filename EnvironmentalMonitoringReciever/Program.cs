using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EnvironmentalMonitoringReciever
{
    class Program
    {
<<<<<<< HEAD
        static List<string> inputvalues=new List<string>();
        
        static void Main(string[] args)
=======
       

        static void Main()
>>>>>>> 38ff5323619894b59ff3311a1eb4fdfc29aad8ff
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
<<<<<<< HEAD
        
        public class ReadConsoleOutput
        {
            
            public int val;
            internal void temperatureread(string input)
=======
        public class OutputCapture : TextWriter
        {
            private readonly TextWriter _stdOutWriter;
            public TextWriter Captured { get; }
            public override Encoding Encoding => Encoding.ASCII;

            public OutputCapture()
            {
                this._stdOutWriter = Console.Out;
                Console.SetOut(this);
                Captured = new StringWriter();
            }

            public override void Write(string output)
>>>>>>> 38ff5323619894b59ff3311a1eb4fdfc29aad8ff
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
                
<<<<<<< HEAD
=======
                Captured.Write(output);
                _stdOutWriter.Write(output);
>>>>>>> 38ff5323619894b59ff3311a1eb4fdfc29aad8ff
            }
            internal void humidityread(string input)
            {
                string tmp = input.Split(':')[1].TrimStart();
                val = Convert.ToInt32(tmp);
                ValueChecker value = new ValueChecker();
                value.Humidity(val);

<<<<<<< HEAD
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
=======
            public override void WriteLine(string output)
            {
               
                Captured.WriteLine(output);
                _stdOutWriter.WriteLine(output);
>>>>>>> 38ff5323619894b59ff3311a1eb4fdfc29aad8ff
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
