using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    //Short 53 Ft Trailer class extends to Trailer
    public class FtTrailer :Trailer
    {
        public FtTrailer()
        {

        }
        public FtTrailer(string id, string aTerminal, string aStatus, double aWidth, double aHeight, double aLength)
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
