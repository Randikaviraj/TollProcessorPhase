using System;
using Xunit;
using BusinessLayer;
using System.Collections.Generic;

namespace TestLayer
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalculateToll()
        {
            CommercialTollProcessor commercialTollProcessor = new CommercialTollProcessor(new Dictionary<string, double>()
                {
                {"2 axles" ,2.50},
                {"3 axles" ,3.50},
                {"4 axles" ,4.50},
                {"5 axles" ,5.00},
                {"7 axles" ,7.00}
            });
            double cost;
            string axle;
            (cost,axle) = commercialTollProcessor.CalculateToll(1);
            Assert.Equal(2.50, cost);
            Assert.Equal("2 axles", axle);
            
        }
    }
}
