using System;

namespace EnvironmentalMonitoringReciever
{

    public class TemperatureValueChecker
    {
        string logstatus;
       TemperatureAlert temperatureAlert = new TemperatureAlert();
        public string Temperature(int temperatureValue)
            {

            if (temperatureValue>37 )
            {
                Temperature1(temperatureValue);
                logstatus = "Temperature is in  high warning level";
            }
            if (temperatureValue < 4)
            {
                Temperature2(temperatureValue);
                logstatus = "Temperature is in  low warning level";
            }
            
            return logstatus;

        }
        public string Temperature1(int temperatureValue1)
        {
            if (temperatureValue1 > 40)
            {
                temperatureAlert.TemperatureHighErrorLevel();
            }
            else
                temperatureAlert.TemperatureHighWarningLevel();
            logstatus = "Temperature is high error level";
            return logstatus;
        }
        public string Temperature2(int temperatureValue2)
        {
            if (temperatureValue2 < 0)
            {
                temperatureAlert.TemperatureLowErrorLevel();
            }
            else
                temperatureAlert.TemperatureLowWarningLevel();
            logstatus = "Temperature is low error level";
            return logstatus;
        }
    }

}
    
