namespace EnvironmentalMonitoringReciever
{

    public class TemperatureValueChecker

    {
        string _logstatus;
       TemperatureAlert temperatureAlert = new TemperatureAlert();
        public string Temperature(int temperatureValue)
            {

            if (temperatureValue>37 )
            {
                Temperature1(temperatureValue);
                _logstatus = "Temperature is in  high warning level";
            }
            if (temperatureValue < 4)
            {
                Temperature2(temperatureValue);
                _logstatus = "Temperature is in  low warning level";
            }
            
            return _logstatus;

        }
        public string Temperature1(int temperatureValue1)
        {
            if (temperatureValue1 > 40)
            {
                temperatureAlert.TemperatureHighErrorLevel();
            }
            else
                temperatureAlert.TemperatureHighWarningLevel();
            _logstatus = "Temperature is high error level";
            return _logstatus;
        }
        public string Temperature2(int temperatureValue2)
        {
            if (temperatureValue2 < 0)
            {
                temperatureAlert.TemperatureLowErrorLevel();
            }
            else
                temperatureAlert.TemperatureLowWarningLevel();
            _logstatus = "Temperature is low error level";
            return _logstatus;
        }
    }

}
    
