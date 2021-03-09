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

        public void AddNewTrailer(Trailer trailer)
        {
            trailers.Add(trailer.ID, trailer);
        }

        public void RemoveTrailer(string id)
        {
            trailers.Remove(id);
        }


        public void AddNewTractor(Tractor tractor)
        {
            tractors.Add(tractor.ID, tractor);
        }


        public void RemoveTractor(string id)
        {
            tractors.Remove(id);
        }

        public Dictionary<string, Trailer> ViewTrailers()
        {
            return trailers;
        }

        public Dictionary<string, Tractor> ViewTractors()
        {
            return tractors;
        }
    }
}
