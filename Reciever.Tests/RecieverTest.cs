using System;
using Xunit;

namespace Reciever.Tests
{
    public class Reciever
    {
        internal void temperaturecheck(int tempvalue)
        {
            if (temperatureValue >= 37 && temperatureValue < 40)
            {
                temperatureAlert.TemperatureHighWarningLevel();
            }
            else if (temperatureValue > 40)
            {
                temperatureAlert.TemperatureHighErrorLevel();
            }
            if (temperatureValue >= 0 && temperatureValue < 4)
            {
                temperatureAlert.TemperatureLowWarningLevel();

            }
            else if (temperatureValue < 0)
            {
                temperatureAlert.TemperatureLowErrorLevel();
            }
        }
        internal void humiditycheck(int humidvalue)
        {
            if (humidityValue >= 70)
            {
                humidityAlert.HumidityHighWarningLevel();
            }
            else if (humidityValue >= 90)
            {
                humidityAlert.HumidityHighErrorLevel();
            }

        }

    }

    public class RecieverTest
    {
        Reciever rec = new Reciever();
        [Fact]
        public void WhenTempratureIsHighInWarningLevelThenSendAlert()
        {
            rec.temperaturecheck(39);
            Assert.True("Tshe Temperature is high..");
        }
        [Fact]
        public void WhenTempratureIsHighInErrorLevelThenSendAlert()
        {
            rec.temperaturecheck(55);
            Assert.True("The Temperature is critically high..");
        }
        [Fact]
        public void WhenTempratureIsLowInWarningLevelThenSendAlert()
        {
            rec.temperaturecheck(3);
            Assert.True("The Temperature is Low..");
        }
        [Fact]
        public void WhenTempratureIsLowInErrorLevelThenSendAlert()
        {
            rec.temperaturecheck(0);
            Assert.True("The Temperature is critically low..");
        }
        [Fact]
        public void WhenHumidityIsHighInWarningLevelThenSendAlert()
        {
            rec.humiditycheck(75);
            Assert.True("The Humidity is high..");
        }
        [Fact]
        public void WhenHumidityIsHighInErrorLevelThenSendAlert()
        {
            rec.humiditycheck(75);
            Assert.True("The Humidity is critically high..");
        }
    }
}
