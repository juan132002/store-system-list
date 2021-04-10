using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_system_list
{
    public class Sales
    {
        public Product Product;
        public Clients Clients;
        public int Cantid;
        public float TotalPrice()
        {
            return Cantid;
        }
    }
}
