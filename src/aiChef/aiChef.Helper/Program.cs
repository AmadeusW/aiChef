using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace aiChef.Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            readData();
        }

        private static void readData()
        {
            var rawData = File.ReadAllText(@"C:\Users\Amadeus\Documents\GitHub\aiChef\data\openrecipes.json");
            var data = JsonConvert.DeserializeObject(rawData);
        }
    }
}
