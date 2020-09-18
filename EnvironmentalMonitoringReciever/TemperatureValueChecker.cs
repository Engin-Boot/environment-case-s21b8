using System;

namespace EnvironmentalMonitoringReciever
{
    class TemperatureValueChecker
    {


        TemperatureAlert temperatureAlert = new TemperatureAlert();


        public void Temperature(int temperatureValue)
        {

            if (temperatureValue > 37)
                
            {
                
                if (temperatureValue>40)
                {
                    temperatureAlert.TemperatureHighErrorLevel();
                    
                }
                else
                temperatureAlert.TemperatureHighWarningLevel();
            }
           
        
            if (temperatureValue > 0 && temperatureValue < 4)
            {
                if(temperatureValue<0)
                    temperatureAlert.TemperatureLowErrorLevel();
                else
                temperatureAlert.TemperatureLowWarningLevel();

            }
            

        }



        
    }
}
