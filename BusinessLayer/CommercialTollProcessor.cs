using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    //CommercialTollProcessor class implements to ITollProcessor interface
    public class CommercialTollProcessor : ITollProcessor
    {
        Dictionary<string, double> tollitems;//CommercialTollProcessorl toll items store in a dictonary with key of text and value as rate

        public CommercialTollProcessor(Dictionary<string, double> items)
        {
            tollitems = items;
        }

        //Calculate the rate on the selection given by argument selection, no matching throws error as wrong input
        public Tuple<double, string> CalculateToll(int selection)
        {
            double cost;
            string axle;
            switch (selection){
                case (int)Axles.TwoAxles:
                    cost= tollitems.ElementAt(0).Value;
                    axle = tollitems.ElementAt(0).Key;
                    break;
                case (int)Axles.ThreeAxles:
                    cost = tollitems.ElementAt(1).Value;
                    axle = tollitems.ElementAt(1).Key;
                    break;
                case (int)Axles.FourAxles:
                    cost = tollitems.ElementAt(2).Value;
                    axle = tollitems.ElementAt(2).Key;
                    break;
                case (int)Axles.FiveAxles:
                    cost = tollitems.ElementAt(3).Value;
                    axle = tollitems.ElementAt(3).Key;
                    break;
                case (int)Axles.SevenAxles:
                    cost = tollitems.ElementAt(4).Value;
                    axle = tollitems.ElementAt(4).Key;
                    break;
                default:
                    throw new Exception("Wrong Selection");
            }

            return Tuple.Create(cost, axle);
        }

        //Display the CommercialTollProcessor submenu 
        public Dictionary<string, double> DisplayMenu()
        {
            
            return tollitems;
        }
    }
}
