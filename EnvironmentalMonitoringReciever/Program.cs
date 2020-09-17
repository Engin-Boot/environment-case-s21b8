using System;
using System.IO;
using System.Text;

namespace EnvironmentalMonitoringReciever
{
    class Program
    {
       

        static void Main()
        {
            using (var outputCapture = new OutputCapture())
            {
                
                Console.WriteLine("50");
                var stuff = outputCapture.Captured.ToString();
                int val = Convert.ToInt32(stuff);
                ValueChecker valueChecker = new ValueChecker();
                valueChecker.Temperature(val);
            }
        }
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
            {
                
                Captured.Write(output);
                _stdOutWriter.Write(output);
            }

            public override void WriteLine(string output)
            {
               
                Captured.WriteLine(output);
                _stdOutWriter.WriteLine(output);
            }
           

        }
    }
}
