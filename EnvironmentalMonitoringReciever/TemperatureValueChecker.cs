namespace EnvironmentalMonitoringReciever
{
    class TemperatureValueChecker
    {
        public void Temperature(int temperatureValue)
        {
            TemperatureAlert temperatureAlert = new TemperatureAlert();
            if (temperatureValue>=37&&temperatureValue<40)
            {
                temperatureAlert.TemperatureHighWarningLevel();
            }
            else if(temperatureValue>40)
            {
                temperatureAlert.TemperatureHighErrorLevel();
            }
            if(temperatureValue>=0&&temperatureValue<4)
            {
                temperatureAlert.TemperatureLowWarningLevel();

            }
            else if(temperatureValue<0)
            {
                temperatureAlert.TemperatureLowErrorLevel();
            }
          
               
        }
        
    }
}
