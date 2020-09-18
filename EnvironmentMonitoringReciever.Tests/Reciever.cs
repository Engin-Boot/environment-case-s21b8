using EnvironmentalMonitoringReciever;
using Xunit;

namespace EnvironmentMonitoringReciever.Tests
{

    public class EnvironmentalMonitoringReciever
    {
        public int Value;

        [Fact]
        public void WhenTemperatureIsHighWarningLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = 39;
            Assert.True(checker.Temperature(Value) == "Temperature is in  high warning level");
        }
        [Fact]
        public void WhenTemperatureIsLowWarningLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = 3;
            Assert.True(checker.Temperature(Value) == "Temperature is in  low warning level");
        }
        [Fact]
        public void WhenTemperatureIsHighErrorLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = 43;
            Assert.True(checker.Temperature1(Value) == "Temperature is high error level");
        }
        [Fact]
        public void WhenTemperatureIsLowErrorLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = -1;
            Assert.True(checker.Temperature2(Value) == "Temperature is low error level");
        }
        [Fact]
        public void WhenHumidityIsHighWarningLevelThenAlertIsSent()
        {
            HumidityValueChecker checker = new HumidityValueChecker();
            Value = 71;
            Assert.True(checker.Humidity(Value) == "Humidity is in warning level");
        }
        [Fact]
        public void WhenHumidityIsHighErrorLevelThenAlertIsSent()
        {
            HumidityValueChecker checker = new HumidityValueChecker();
            Value = 91;
            Assert.True(checker.Humidity(Value) == "Humidity is in error level");
        }
    }
}
