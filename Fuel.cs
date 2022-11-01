using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прога_для_Газпрома
{
    internal class Fuel
    {
        Dictionary<string, double> fuels = new Dictionary<string, double>();
        public Fuel()
        {
            fuels.Add("AИ-76", 47.21);
            fuels.Add("AИ-95", 52.04);
            fuels.Add("ДТ", 54.72);
        }

        public double GetFuelPrice(string key)
        {
            double price = 0;
            foreach (var item in fuels)
            {
                if(item.Key==key)
                {
                    price = item.Value;
                }
            }
            return price;
        }

        public string GetFuelName(int i)
        {
            int j = 0;
            string name = "";

            foreach(var item in fuels)
            {
                if (i == j)
                {
                    return item.Key;
                }
                j++;
            }

            return name;
        }

        public int GetCount()
        {
            return fuels.Count;
        }

        public void AddFuel(string key, double price)
        {
            fuels.Add(key, price);
        }
    }
}
