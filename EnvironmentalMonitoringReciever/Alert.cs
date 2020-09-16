using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalMonitoringReciever
{
    
        class TemperatureAlert
       {
        public  void TemperatureHighWarningLevel()
        {
           Console.WriteLine("The Temperature is high..");
        }
        public void TemperatureLowWarningLevel()
        {
           Console.WriteLine("The Temperature is Low..");
        }
        public void TemperatureHighErrorLevel()
        {
           Console.WriteLine("The Temperature is critically high..");
        }
        public void TemperatureLowErrorLevel()
        {
           Console.WriteLine("The Temperature is critically low..");
        }
        }
        class HumidityAlert
        {
            public void HumidityHighWarningLevel()
            {
                Console.WriteLine("The Humidity is high..");
            }
           
            public void HumidityHighErrorLevel()
            {
                Console.WriteLine("The Humidity is critically high..");
            }
            
        }
   
}
