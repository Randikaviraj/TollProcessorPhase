using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    //Tractor class
    public class Tractor
    {
        private string id;
        private string terminal;
        private string status;

        public Tractor()
        {

        }

        public Tractor(string id, string terminal, string status)
        {
            ID = id;
            Terminal = terminal;
            Status = status;
        }

        //getters and setters of id and setter check the requird type
        public String ID
        {
            get { return id; }


            set
            {
                if (value.Length == 6 && value[0] == 'T' && value[1] == 'C')
                {
                    for (int i = 2; i < value.Length; i++)
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
                if (int.Parse(value) <= 3 && int.Parse(value) >0)
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
                if (value.Equals("Arrived") || value.Equals("Fueled”") || value.Equals("Serviced") || value.Equals(" Ready"))
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
