using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class TollProcessorFactory
    {
        private CommercialTollProcessor commercialTollProcessor;
        private ResidentialTollProcessor residentialTollProcessor;

        public TollProcessorFactory()
        {
            //factory of making objects in CommercialTollProcessor and ResidentialTollProcessor
            commercialTollProcessor = new CommercialTollProcessor(new Dictionary<string, double>()
            {
                {"2 axles" ,2.50},
                {"3 axles" ,3.50},
                {"4 axles" ,4.50},
                {"5 axles" ,5.00},
                {"7 axles" ,7.00}
            });

            residentialTollProcessor = new ResidentialTollProcessor(new Dictionary<string, double>()
            {
                {"2 axles" ,2.00},
                {"3 axles" ,3.00},
                {"4 axles" ,4.00}
            });
        }

        //factory method for return the CommercialTollProcessor or ResidentialTollProcessor reference depend on the input value
        public ITollProcessor FactoryMethod(int value)
        {
            ITollProcessor tollProcessor;
            switch (value)
            {
                case 1:
                    tollProcessor = residentialTollProcessor;
                    break;
                case 2:
                    tollProcessor = commercialTollProcessor;
                    break;
                default:
                    throw new Exception("Wrong selection");
            }

            return tollProcessor;
        }
    }
}
