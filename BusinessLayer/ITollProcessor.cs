using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //interface of  ITollProcessor two method are defined to calculate the toll and display the sub menus
    public interface ITollProcessor
    {
        Dictionary<string, double> DisplayMenu();
        Tuple<double, string> CalculateToll(int selection);
    }
}
