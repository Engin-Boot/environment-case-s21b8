namespace EnvironmentalMonitoringReciever
{
    class ValueChecker
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
        public void Humidity(float humidityValue)
        {
            HumidityAlert humidityAlert = new HumidityAlert();
            if(humidityValue>=70)
            {
                humidityAlert.HumidityHighWarningLevel();
            }
            else if(humidityValue>=90)
            {
                humidityAlert.HumidityHighErrorLevel();
            }
            

        }
    }
}
