using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaba.Koatuu
{
    public class KoatuuManager
    {
        private List<City> cities;
        public async Task<bool> LoadData()
        {
            cities = JsonConvert.DeserializeObject<List<City>>(await new StreamReader("koatuu.json").ReadToEndAsync());
            if (cities != null || cities.Count > 0)
                return true;
            return false;
        }

        public List<City> GetAllCities() => cities;

        public List<City> GetCitiesByName(string name) => cities.Where(d => d.Name.Contains(name.ToUpper())).ToList();
    }
}