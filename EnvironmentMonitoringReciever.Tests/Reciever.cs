using EnvironmentalMonitoringReciever;
using Xunit;

namespace EnvironmentMonitoringReciever.Tests
{

    public class EnvironmentalMonitoringReciever
    {
        private int _value;

        [Fact]
        public void WhenTemperatureIsHighWarningLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            _value = 39;
            Assert.True(checker.Temperature(_value) == "Temperature is in  high warning level");
        }
        [Fact]
        public void WhenTemperatureIsLowWarningLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            _value = 3;
            Assert.True(checker.Temperature(_value) == "Temperature is in  low warning level");
        }
        [Fact]
        public void WhenTemperatureIsHighErrorLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            _value = 43;
            Assert.True(checker.Temperature1(_value) == "Temperature is high error level");
        }
        [Fact]
        public void WhenTemperatureIsLowErrorLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            _value = -1;
            Assert.True(checker.Temperature2(_value) == "Temperature is low error level");
        }
        [Fact]
        public void WhenHumidityIsHighWarningLevelThenAlertIsSent()
        {
            HumidityValueChecker checker = new HumidityValueChecker();
            _value = 71;
            Assert.True(checker.Humidity(_value) == "Humidity is in warning level");
        }
        [Fact]
        public void WhenHumidityIsHighErrorLevelThenAlertIsSent()
        {
            HumidityValueChecker checker = new HumidityValueChecker();
            _value = 91;
            Assert.True(checker.Humidity(_value) == "Humidity is in error level");
        }
    }
}
