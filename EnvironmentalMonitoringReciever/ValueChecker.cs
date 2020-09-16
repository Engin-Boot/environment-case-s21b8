using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalMonitoringReciever
{
    class ValueChecker
    {
        public void Temperature(int TemperatureValue)
        {
            TemperatureAlert temperatureAlert = new TemperatureAlert();
            if (TemperatureValue>=37&&TemperatureValue<40)
            {
                temperatureAlert.TemperatureHighWarningLevel();
            }
            else if(TemperatureValue>40)
            {
                temperatureAlert.TemperatureHighErrorLevel();
            }
           if(TemperatureValue>=0&&TemperatureValue<4)
            {
                temperatureAlert.TemperatureLowWarningLevel();

            }
            else if(TemperatureValue<0)
            {
                temperatureAlert.TemperatureLowErrorLevel();
            }
          
               
        }
        public void Humidity(float HumidityValue)
        {
            HumidityAlert humidityAlert = new HumidityAlert();
            if(HumidityValue>=70)
            {
                humidityAlert.HumidityHighWarningLevel();
            }
            else if(HumidityValue>=90)
            {
                humidityAlert.HumidityHighErrorLevel();
            }
            

        }
    }
}
