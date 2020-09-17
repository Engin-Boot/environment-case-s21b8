using System;
using Xunit;

namespace Reciever.Tests
{
    public class Reciever
    {
        public bool alertIsSent = false;
        public string calledMessage;
        public int sentvalue;
        public void temperaturecheck(int tempvalue,string message)
        {
            alertIsSent = true;
            calledMessage = message;
            sentvalue = tempvalue;
        }

    }

    public class RecieverTest
    {
        
        
        [Fact]
        public void WhenTempratureIsHighInWarningLevelThenSendAlert()
        {
            Reciever rec = new Reciever();
            
            Assert.True(rec.alertIsSent);
            //Assert.True(rec.alertIsSent=="The Temperature is high..");
            Assert.True(rec.calledMessage == "The Temperature is high..");
            Assert.True(rec.sentvalue == 40);
        }
        
    }
}
