using System;
using Xunit;

namespace Reciever.Tests
{
    public class Reciever
    {
        public bool alertIsSent = false;
        public string calledMessage;
        public void temperaturecheck(int tempvalue)
        {
            alertIsSent = true;
            calledMessage = message;
        }

    }

    public class RecieverTest
    {
        
        
        [Fact]
        public void WhenTempratureIsHighInWarningLevelThenSendAlert()
        {
            Reciever rec = new Reciever();
            rec.temperaturecheck(39);
            Assert.True(rec.alertIsSent);
            //Assert.True(rec.alertIsSent=="The Temperature is high..");
            Assert.True(rec.calledMessage == "The Temperature is high..");
        }
        
    }
}
