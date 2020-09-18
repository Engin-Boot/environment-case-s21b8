using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalMonitoringReciever
{
    public class HumidityValueChecker
    {
        string logstatus;
        public string Humidity(float humidityValue)
        {
            HumidityAlert humidityAlert = new HumidityAlert();
            if (humidityValue > 70)
            {
                humidityAlert.HumidityHighWarningLevel();
                logstatus = "Humidity is in warning level";
                
            }
            if (humidityValue > 90)
            {
                humidityAlert.HumidityHighErrorLevel();
                logstatus = "Humidity is in error level";
                
            }

            return logstatus;
        }
    }
}
