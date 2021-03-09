using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    //Short Trailer class extends to Trailer
    public class ShortTrailer:Trailer
    {
        public ShortTrailer()
        {

        }
        public ShortTrailer(string id,string aTerminal,string aStatus,double aWidth,double aHeight,double aLength)
        {
            ID = id;
            Terminal = aTerminal;
            Status = aStatus;
            Width = aWidth;
            Height = aHeight;
            Length = aLength;
        }
    }
}
