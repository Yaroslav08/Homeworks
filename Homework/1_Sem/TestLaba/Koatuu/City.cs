using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace TestLaba.Koatuu
{
    public class City
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty("Назва об'єкта українською мовою")]
        public string Name { get; set; }
    }
}