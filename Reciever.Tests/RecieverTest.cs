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
            Debug.Assert("The Temperature is high..");
        }
        [Fact]
        public void WhenTempratureIsHighInErrorLevelThenSendAlert()
        {
            rec.temperaturecheck(55);
            Debug.Assert("The Temperature is critically high..");
        }
        [Fact]
        public void WhenTempratureIsLowInWarningLevelThenSendAlert()
        {
            rec.temperaturecheck(3);
            Debug.Assert("The Temperature is Low..");
        }
        [Fact]
        public void WhenTempratureIsLowInErrorLevelThenSendAlert()
        {
            rec.temperaturecheck(0);
            Debug.Assert("The Temperature is critically low..");
        }
        [Fact]
        public void WhenTempratureIsHighInWarningLevelThenSendAlert()
        {
            rec.humiditycheck(75);
            Debug.Assert("The Humidity is high..");
        }
        [Fact]
        public void WhenTempratureIsHighInErrorLevelThenSendAlert()
        {
            rec.humiditycheck(75);
            Debug.Assert("The Humidity is critically high..");
        }
    }
}
