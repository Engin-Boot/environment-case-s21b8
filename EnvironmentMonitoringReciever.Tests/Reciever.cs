using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EnvironmentalMonitoringReciever;
namespace EnvironmentalMonitoringReciever.Tests
{

    public class EnvironmentalMonitoringReciever
    {
        public int Value;

        [Fact]
        public void whenTemperatureIsHighWarningLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = 39;
            Assert.True(checker.Temperature(Value) == "Temperature is in  high warning level");
        }
        [Fact]
        public void whenTemperatureIsLowWarningLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = 3;
            Assert.True(checker.Temperature(Value) == "Temperature is in  low warning level");
        }
        [Fact]
        public void whenTemperatureIsHighErrorLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = 43;
            Assert.True(checker.Temperature1(Value) == "Temperature is high error level");
        }
        [Fact]
        public void whenTemperatureIsLowErrorLevelThenAlertIsSent()
        {
            TemperatureValueChecker checker = new TemperatureValueChecker();
            Value = -1;
            Assert.True(checker.Temperature2(Value) == "Temperature is low error level");
        }
        [Fact]
        public void whenHumidityIsHighWarningLevelThenAlertIsSent()
        {
            HumidityValueChecker checker = new HumidityValueChecker();
            Value = 71;
            Assert.True(checker.Humidity(Value) == "Humidity is in warning level");
        }
        [Fact]
        public void whenHumidityIsHighErrorLevelThenAlertIsSent()
        {
            HumidityValueChecker checker = new HumidityValueChecker();
            Value = 91;
            Assert.True(checker.Humidity(Value) == "Humidity is in error level");
        }
    }
}
