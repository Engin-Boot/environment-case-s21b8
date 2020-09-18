using System;

namespace EnvironmentalMonitoringReciever
{
    class TemperatureValueChecker
    {
       
        
            TemperatureAlert temperatureAlert = new TemperatureAlert();
        

        public void Temperature(int temperatureValue)
            {

            if (temperatureValue > 37 && temperatureValue < 40)
            {
                temperatureAlert.TemperatureHighWarningLevel();
            }
            else if (temperatureValue > 40)
            {
                temperatureAlert.TemperatureHighErrorLevel();
            }
            if (temperatureValue > 0 && temperatureValue < 4)
            {
                temperatureAlert.TemperatureLowWarningLevel();

            }
            else if (temperatureValue < 0)
            {
                temperatureAlert.TemperatureLowErrorLevel();
            }

            




        }
    }
    }
