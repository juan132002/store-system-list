using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_system_list
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Stock;

        public double TotalVentas()
        {
            return Price;
        }
    }
}
