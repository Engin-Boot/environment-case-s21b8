namespace EnvironmentalMonitoringReciever
{
    public class HumidityValueChecker
    {
        string _logstatus;
        public string Humidity(float humidityValue)
        {
            HumidityAlert humidityAlert = new HumidityAlert();
            if (humidityValue > 70)
            {
                humidityAlert.HumidityHighWarningLevel();
                _logstatus = "Humidity is in warning level";
                
            }
            if (humidityValue > 90)
            {
                humidityAlert.HumidityHighErrorLevel();
                _logstatus = "Humidity is in error level";
                
            }

            return _logstatus;
        }
    }
}
