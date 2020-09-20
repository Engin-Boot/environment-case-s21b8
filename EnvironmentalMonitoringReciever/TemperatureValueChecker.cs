namespace EnvironmentalMonitoringReciever
{

    public class TemperatureValueChecker

    {
        private string _logStatus;
        readonly TemperatureAlert _temperatureAlert = new TemperatureAlert();
        public string Temperature(int temperatureValue)
            {

            if (temperatureValue>37 )
            {
                Temperature1(temperatureValue);
                _logStatus = "Temperature is in  high warning level";
            }
            if (temperatureValue < 4)
            {
                Temperature2(temperatureValue);
                _logStatus = "Temperature is in  low warning level";
            }
            
            return _logStatus;

        }
        public string Temperature1(int temperatureValue1)
        {
            if (temperatureValue1 > 40)
            {
                _temperatureAlert.TemperatureHighErrorLevel();
            }
            else
                _temperatureAlert.TemperatureHighWarningLevel();
            _logStatus = "Temperature is high error level";
            return _logStatus;
        }
        public string Temperature2(int temperatureValue2)
        {
            if (temperatureValue2 < 0)
            {
                _temperatureAlert.TemperatureLowErrorLevel();
            }
            else
                _temperatureAlert.TemperatureLowWarningLevel();
            _logStatus = "Temperature is low error level";
            return _logStatus;
        }
    }

}
    
