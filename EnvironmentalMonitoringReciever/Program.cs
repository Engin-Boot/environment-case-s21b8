using System;
using System.IO;
using System.Text;


namespace EnvironmentalMonitoringReciever
{
    class Program
    {
       

        static void Main(string[] args)
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
        public class OutputCapture : TextWriter, IDisposable
        {
            private TextWriter stdOutWriter;
            public TextWriter Captured { get; private set; }
            public override Encoding Encoding { get { return Encoding.ASCII; } }

            public OutputCapture()
            {
                this.stdOutWriter = Console.Out;
                Console.SetOut(this);
                Captured = new StringWriter();
            }

            override public void Write(string output)
            {
                
                Captured.Write(output);
                stdOutWriter.Write(output);
            }

            override public void WriteLine(string output)
            {
               
                Captured.WriteLine(output);
                stdOutWriter.WriteLine(output);
            }
           

        }
    }
}
