using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalMonitoringReciever
{
    class HumidityValueChecker
    {
        public void Humidity(float humidityValue)
        {
            HumidityAlert humidityAlert = new HumidityAlert();
            if (humidityValue > 70)
            {
                humidityAlert.HumidityHighWarningLevel();
            }
            else if (humidityValue > 90)
            {
                humidityAlert.HumidityHighErrorLevel();
            }


        }
    }
}
