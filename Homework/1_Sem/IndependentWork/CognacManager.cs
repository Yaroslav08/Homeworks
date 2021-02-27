using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndependentWork
{
    public class CognacManager
    {
        private List<Cognac> cognacs = new List<Cognac>();
        public CognacManager()
        {
            cognacs = new List<Cognac>
            {
                new Cognac(700, 55, "Ukr", 1.5),
                new Cognac(600, 50, "Fr", 1.0),
                new Cognac(400, 40, "Bel", 1.5),
                new Cognac(700, 55, "Ukr", 1.5),
                new Cognac(800, 65, "Ukr", 1.5)
            };
        }
        public List<Cognac> GetAllCognacs() => cognacs;
        public List<Cognac> GetByCountry(string name) => cognacs.Where(d => d.CountryProducer == name).ToList();
        public List<Cognac> GetByPrice(double price) => cognacs.Where(d => d.Price == price).ToList();
        public List<Cognac> GetByVolume(double volume) => cognacs.Where(d => d.Volume == volume).ToList();
    }
}
