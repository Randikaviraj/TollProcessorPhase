using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    //ResidentialTollProcessor class implements to ITollProcessor interface
    public class ResidentialTollProcessor : ITollProcessor
    {
        Dictionary<string, double> tollitems; //Residential toll items store in a dictonary with key of text and value as rate

        public ResidentialTollProcessor(Dictionary<string, double> items)
        {
            tollitems = items;
        }


        //Calculate the rate on the selection given by argument selection, no matching throws error as wrong input
        public Tuple<double, string> CalculateToll(int selection)
        {
            double cost;
            string axle;

            switch (selection)
            {
                case (int)Axles.TwoAxles:
                    cost = tollitems.ElementAt(0).Value;
                    axle = tollitems.ElementAt(0).Key;
                    break;
                case (int)Axles.ThreeAxles:
                    cost = tollitems.ElementAt(1).Value;
                    axle = tollitems.ElementAt(0).Key;
                    break;
                case (int)Axles.FourAxles:
                    cost = tollitems.ElementAt(2).Value;
                    axle = tollitems.ElementAt(0).Key;
                    break;
                default:
                    throw new Exception("Wrong Selection");
            }

            return Tuple.Create(cost,axle);
        }

        //Display the Residental submenu 
        public Dictionary<string, double> DisplayMenu()
        {
            Console.WriteLine("Residental -Submenu ------------");
            Console.WriteLine("Select number for menu option:");
            for (int i = 0; i < tollitems.Count; i++)
            {
                Console.WriteLine(" "+(i+1) + ". " + tollitems.ElementAt(i).Key);
            }
            return tollitems;
        }
    }
}
