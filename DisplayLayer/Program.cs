using System;
using BusinessLayer;

namespace DisplayLayer
{
    class Program
    {
        private static TollProcessorFactory tollProcessorFactory = new TollProcessorFactory();
        static void Main(string[] args)
        {
            int selection;

            while (true)
            {
                Console.WriteLine("Select number for menu option:");
                Console.WriteLine(" 1.  Residential");
                Console.WriteLine(" 2.  Commercial");
                Console.WriteLine(" 3.  Equipment Management");
                Console.WriteLine(" 4.  Exit");
                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                    switch (selection)
                    {
                        case 1:
                            ShowSubMenu(1);
                            break;
                        case 2:
                            ShowSubMenu(2);
                            break;
                        case 3:
                            ShowManagementOption();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Help : Enter valid option");
                            Console.WriteLine("");
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("Help : Enter valid option");
                    Console.WriteLine("");
                }
                

            }
            
        }

        static void ShowSubMenu(int selection)
        {
            int subMenuSelction;
            double cost;
            string axle;
            while (true)
            {
                ITollProcessor itollProcesser = tollProcessorFactory.FactoryMethod(selection);
                itollProcesser.DisplayMenu();
                try
                {
                    subMenuSelction = Convert.ToInt32(Console.ReadLine());
                    (cost,axle)=itollProcesser.CalculateToll(subMenuSelction);
                    Console.WriteLine("Charge for the "+axle+" is $"+cost);
                    Console.WriteLine("");
                    return;
                }
                catch
                {
                    Console.WriteLine("Help : Enter valid option");
                    Console.WriteLine("");
                }
                
            }
            
        }


        static void ShowManagementOption()
        {
            int subMenuSelction;
            InventoryManager inventoryManager = new InventoryManager();
            while (true)
            {
                Console.WriteLine(" 1.  Add Short Trailer");
                Console.WriteLine(" 2.  Add 53 FT Trailer");
                Console.WriteLine(" 3.  Remove Short Trailer");
                Console.WriteLine(" 4.  Remove 53 FT Trailer");
                Console.WriteLine(" 5.  View Trailers");
                Console.WriteLine(" 6.  Add Tractor");
                Console.WriteLine(" 7.  Remove Tractor");
                Console.WriteLine(" 8.   View Tractors");
                Console.WriteLine(" 9.   Back");

                try
                {
                    subMenuSelction = Convert.ToInt32(Console.ReadLine());
                    switch (subMenuSelction)
                    {
                        case 1:
                            Trailer trailer1 =new  ShortTrailer();
                            trailer1 = GetTrailerDetails(trailer1);
                            if (trailer1 != null)
                            {

                                inventoryManager.AddNewTrailer(trailer1);
                            }

                            break;
                        case 2:
                            Trailer trailer2 = new FtTrailer();
                            trailer2 = GetTrailerDetails(trailer2);
                            if (trailer2 != null)
                            {

                                inventoryManager.AddNewTrailer(trailer2);
                            }
                            break;
                        case 3:
                            string id = GetId();
                            if (id != null)
                            {
                                inventoryManager.RemoveTrailer(id);
                            }
                            break;
                        case 4:
                            string id2 = GetId();
                            if (id2 != null)
                            {
                                inventoryManager.RemoveTrailer(id2);
                            }
                            break;
                        case 5:
                            foreach (var ele1 in inventoryManager.ViewTractors())
                            {
                                Console.WriteLine(ele1.Key);
                            }
                            
                            break;
                        case 6:
                            Tractor tractor = new Tractor();
                            tractor = GetTractorDetails(tractor);
                            if (tractor != null)
                            {
                                inventoryManager.AddNewTractor(tractor);
                            }
                            break;
                        case 7:
                            string id3 = GetId();
                            if (id3 != null)
                            {
                                inventoryManager.RemoveTractor(id3);
                            }
                            break;
                        case 8:
                            foreach (var ele2 in inventoryManager.ViewTractors())
                            {
                                Console.WriteLine(ele2.Key);
                            }
                            
                            break;
                        case 9:
                            return;
                        default:
                            Console.WriteLine("Help : Enter valid option");
                            Console.WriteLine("");
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("Help : Enter valid option");
                    Console.WriteLine("");
                }

            }
        }


        static Trailer GetTrailerDetails(Trailer trailer)
        {
            string id;
            string terminal;
            string status;
            double Width, Height, Length;

            try
            {
                Console.Write("Enter ID :");
                id = Console.ReadLine();
                Console.Write("Enter Terminal :");
                terminal = Console.ReadLine();
                Console.Write("Enter Status :");
                status = Console.ReadLine();
                Console.Write("Enter Width :");
                Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Height :");
                Height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Lenghth :");
                Length = Convert.ToDouble(Console.ReadLine());

                trailer.Length = Length;
                trailer.Height = Height;
                trailer.Width = Width;
                trailer.ID = id;
                trailer.Status = status;
                trailer.Terminal = terminal;
            }
            catch
            {
                Console.WriteLine("Help : Invalid information,");
                Console.WriteLine("");
                return null;
            }

            return trailer;
        }

        static Tractor GetTractorDetails(Tractor tractor)
        {
            string id;
            string terminal;
            string status;
            try
            {
                Console.Write("Enter ID :");
                id = Console.ReadLine();
                Console.Write("Enter Terminal :");
                terminal = Console.ReadLine();
                Console.Write("Enter Status :");
                status = Console.ReadLine();

                tractor.ID = id;
                tractor.Status = status;
                tractor.Terminal = terminal;

            }
            catch
            {
                Console.WriteLine("Help : Invalid information,");
                Console.WriteLine("");
                return null;
            }

            return tractor;
        }

        static string GetId()
        {
            string id;
            try
            {
                Console.Write("Enter ID :");
                id = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Help : Invalid information,");
                Console.WriteLine("");
                return null;
            }
            return id;

        }
    }
}
