using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_system_list
{
    public class SalesList
    {
        public ProductNodo Head01;
        public ClientsNodo Head02;
        public SalesNodo Head03;



        public void AddProduct(Product productToAdd)
        {
            ProductNodo newproductNodo = new ProductNodo();
            newproductNodo.Product = productToAdd;

            if (Head01 == null)
            {
                Head01 = newproductNodo;
            }
            else
            {
                ProductNodo last = Head01;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newproductNodo;
            }


        }


        public void AddClients(Clients clientsToAdd)
        {
            ClientsNodo newclientsNodo = new ClientsNodo();
            newclientsNodo.Clients = clientsToAdd;
            if (Head02 == null)
            {
                Head02 = newclientsNodo;
            }
            else
            {
                ClientsNodo last = Head02;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newclientsNodo;
            }
        }

        Sales[] Sales = new Sales[30];
        int salesCount = 0;
        public void AddSale(Sales newSales)
        {
            Sales[salesCount] = newSales;
            salesCount++;
        }

        public void AddSales(Sales salesToAdd)
        {
            SalesNodo newsalesNodo = new SalesNodo();
            newsalesNodo.sales = salesToAdd;

            if (Head03 == null)
            {
                Head03 = newsalesNodo;
            }
            else
            {
                SalesNodo last = Head03;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newsalesNodo;
            }
        }


        public double TotalVentas()
        {
            double totalsales = 0;
            for (int t = 0; t < salesCount; t++)
            {
                totalsales = totalsales + Sales[t].Product.TotalVentas();

            }
            return totalsales;
        }

        public Sales TotalStockC()
        {
            Sales totalStockc = Sales[0];
            for (int i = 1; i < salesCount; i++)
            {
                if (Sales[i].Product.TotalVentas() > totalStockc.Product.TotalVentas())
                {
                    totalStockc = Sales[i];
                }
            }
            return totalStockc;
        }





        public double SumSales()
        {
            double totalVentas = 0;
            for (int t = 0; t < salesCount; t++)
            {
                totalVentas = totalVentas + Sales[t].TotalPrice();
            }
            return totalVentas;

        }

        public Sales MoreSalesProduc()
        {

            Sales moresales = Sales[0];
            for (int i = 0; i < salesCount; i++)
            {
                if (Sales[i].TotalPrice() > moresales.TotalPrice())
                {

                    moresales = Sales[i];

                }
            }
            return moresales;
        }

        public double PromedioSales()
        {
            double sales = 0;
            for (int i = 0; i < salesCount; i++)
            {
                sales = sales + Sales[i].Product.TotalVentas() / salesCount;
            }
            return sales;
        }

        public void InsertarProduct(Product newproduct, Product after)
        {
            ProductNodo tmp = Head01;
            while (tmp != null && tmp.Product != after)
            {
                tmp = tmp.Next;
            }
            ProductNodo newnodoP = new ProductNodo();
            newnodoP.Product = newproduct;

            newnodoP.Next = tmp.Next;
            tmp.Next = newnodoP;
        }

        public void InsertarClients(Clients newclients, Clients after)
        {
            ClientsNodo tmp = Head02;
            while (tmp != null && tmp.Clients != after)
            {
                tmp = tmp.Next;
            }
            ClientsNodo newnodoC = new ClientsNodo();
            newnodoC.Clients = newclients;

            newnodoC.Next = tmp.Next;
            tmp.Next = newnodoC;
        }

        public void BorrarProduct()
        {
            ProductNodo last, last2;
            last = Head01;
            last2 = Head01;

            while (last2.Next != null)
            {
                last = last2;
                last2 = last.Next;
            }
            last.Next = null;
        }

        public void BorrarClients()
        {
            ClientsNodo last, last2;
            last = Head02;
            last2 = Head02;

            while (last2.Next != null)
            {
                last = last2;
                last2 = last.Next;
            }
            last.Next = null;

        }

        public void PrintProducts()
        {
            ProductNodo PrProduct = Head01;
            while (PrProduct != null)
            {
                Console.WriteLine($"Nombre Product:  { PrProduct.Product.Name} -> Price Product: {PrProduct.Product.Price} -> Stock Product: {PrProduct.Product.Stock}");
                PrProduct = PrProduct.Next;
            }
        }

        public void PrintClients()
        {
            ClientsNodo PrClients = Head02;
            while (PrClients != null)
            {
                Console.WriteLine($"Nombre Clients: {PrClients.Clients.Name} -> Age Clients: {PrClients.Clients.Age} -> Gender Clients: {PrClients.Clients.Gender}");
                PrClients = PrClients.Next;
            }
        }

        public void PrintSales()
        {
            SalesNodo PrSales = Head03;
            while (PrSales != null)
            {
                Console.WriteLine($"Nombre Clients: {PrSales.sales.Clients.Name}");
                Console.WriteLine($"Nombre Products: {PrSales.sales.Product.Name}");

                PrSales = PrSales.Next;
            }
        }


    }
}
}
