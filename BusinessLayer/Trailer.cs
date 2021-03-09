using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    //Trailer class
    public class Trailer
    {
        private string id;
        private string terminal;
        private string status;
        public double Width, Height, Length;

        //getters and setters of Id and setter check the requird type
        public String ID
        {
            get { return id; }


            set
            {
                if (value.Length == 7 && value[0]=='T' && value[1] == 'R')
                {
                    for(int i=2;i< value.Length; i++)
                    {
                        int.Parse(value[i].ToString());
                    }
                    id = value;
                }
                else
                {
                    throw new Exception("Input Error");
                }
            }
        }

        //getters and setters of terminal and setter check the requird type
        public string Terminal
        {
            get { return terminal; }

            set
            {
                if (int.Parse(value) <=10 && int.Parse(value)> 0)
                {
                    terminal = value;
                }
                else
                {
                    throw new Exception("Input Error");
                }
            }
        }

        //getters and setters of status and setter check the requird type
        public string Status
        {
            get { return status; }

            set
            {
                if (value.Equals("Empty") || value.Equals("In Progress") || value.Equals("Loaded"))
                {
                    status = value;
                }
                else
                {
                    throw new Exception("Input Error");
                }
            }
        }
    }
}
