using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    
    public class InventoryManager
    {
        private Dictionary<string, Trailer> trailers;
        private Dictionary<string, Tractor> tractors;

        public InventoryManager()
        {
            trailers = new Dictionary<string, Trailer>();
            tractors = new Dictionary<string, Tractor>();
        }

        //Adding new Trailer
        public void AddNewTrailer(Trailer trailer)
        {
            trailers.Add(trailer.ID, trailer);
        }

        //Removing a trailer in id
        public void RemoveTrailer(string id)
        {
            trailers.Remove(id);
        }

        //Adding new tractor
        public void AddNewTractor(Tractor tractor)
        {
            tractors.Add(tractor.ID, tractor);
        }

        //removing a Tractor on id
        public void RemoveTractor(string id)
        {
            tractors.Remove(id);
        }

        //return Trailer for viewing
        public Dictionary<string, Trailer> ViewTrailers()
        {
            return trailers;
        }
        //return Tractor viewing
        public Dictionary<string, Tractor> ViewTractors()
        {
            return tractors;
        }
    }
}
