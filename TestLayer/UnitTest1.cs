using System;
using Xunit;
using BusinessLayer;
using System.Collections.Generic;

namespace TestLayer
{
    public class UnitTest1
    {

        /// <summary>
        /// CommercialTollProcessor  test functions
        /// </summary>
        [Fact]
        public void TestCommercialTollProcessorCalculateToll()
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
            Assert.Throws<Exception>(
                () => commercialTollProcessor.CalculateToll(10)
                );

        }
        [Fact]
        public void TestCommercialTollProcessorDisplayMenu()
        {
            Dictionary<string, double> dic = new Dictionary<string, double>()
                {
                {"2 axles" ,2.50},
                {"3 axles" ,3.50},
                {"4 axles" ,4.50},
                {"5 axles" ,5.00},
                {"7 axles" ,7.00}
            };
            CommercialTollProcessor commercialTollProcessor = new CommercialTollProcessor(dic);

            Assert.Equal<Dictionary<string, double>>(dic, commercialTollProcessor.DisplayMenu());

        }

        /// <summary>
        /// ResidentialTollProcessor  test functions
        /// </summary>

        [Fact]
        public void TestResidentalCalculateToll()
        {
            ResidentialTollProcessor residentalTollProcessor = new ResidentialTollProcessor(new Dictionary<string, double>()
                {
                {"2 axles" ,2.00},
                {"3 axles" ,3.00},
                {"4 axles" ,4.00}
            });
            double cost;
            string axle;
            (cost, axle) = residentalTollProcessor.CalculateToll(1);
            Assert.Equal(2.00, cost);
            Assert.Equal("2 axles", axle);
            Assert.Throws<Exception>(
                () => residentalTollProcessor.CalculateToll(10)
                );
        }

        [Fact]
        public void TestResidentalDisplayMenu()
        {
            Dictionary<string, double> dic = new Dictionary<string, double>()
                {
                {"2 axles" ,2.00},
                {"3 axles" ,3.00},
                {"4 axles" ,4.00}
            };
            ResidentialTollProcessor commercialTollProcessor = new ResidentialTollProcessor(dic);

            Assert.Equal<Dictionary<string, double>>(dic, commercialTollProcessor.DisplayMenu());

        }

        /// <summary>
        ///  TollProcessorFactory test functions
        /// </summary>

        [Fact]
        public void TestTollProcessorFactoryFactoryMethod()
        {
            TollProcessorFactory tollProcessorFactory = new TollProcessorFactory();

            Assert.IsType<CommercialTollProcessor>(tollProcessorFactory.FactoryMethod(2));
            Assert.IsType<ResidentialTollProcessor>(tollProcessorFactory.FactoryMethod(1));
            Assert.Throws<Exception>(
                ()=> tollProcessorFactory.FactoryMethod(8)
                );
        }



        /// <summary>
        /// InventoryManager test functions
        /// </summary>
        [Fact]
        public void TestInventoryManagerViewTractors()
        {
            InventoryManager inventoryManager = new InventoryManager();
            Assert.IsType<Dictionary<string, Tractor>>(inventoryManager.ViewTractors());
        }

        [Fact]
        public void TestInventoryManagerViewTrailers()
        {
            InventoryManager inventoryManager = new InventoryManager();
            Assert.IsType<Dictionary<string, Trailer>>(inventoryManager.ViewTrailers());
        }


        [Fact]
        public void InventoryManagerAddNewTrailer()
        {
            InventoryManager inventoryManager = new InventoryManager();
            Assert.Throws<Exception>(

                ()=>inventoryManager.AddNewTrailer(new FtTrailer(
                    "TR00001","01", "Empt",12.1,12.0,11))
                );

            Assert.Throws<Exception>(

                () => inventoryManager.AddNewTractor(new Tractor(
                    "TC0001", "01", "Fuele"))
                );
        }


    }
}
