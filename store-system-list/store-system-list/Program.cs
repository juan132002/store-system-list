 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_system_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalesList salesList = new SalesList();



            Product p1 = new Product();
            p1.Name = "Papel";
            p1.Price = 5000;
            p1.Stock = 30;
            salesList.AddProduct(p1);

            Product p2 = new Product();
            p2.Name = "Papas";
            p2.Price = 8000;
            p2.Stock = 50;
            salesList.AddProduct(p2);

            Product p3 = new Product();
            p3.Name = "Galletas";
            p3.Price = 15000;
            p3.Stock = 20;
            salesList.AddProduct(p3);

            Product p4 = new Product();
            p4.Name = "Chocorramo";
            p4.Price = 20000;
            p4.Stock = 60;
            salesList.AddProduct(p4);

            Product p5 = new Product();
            p5.Name = "Huevos";
            p5.Price = 30000;
            p5.Stock = 30;
            salesList.AddProduct(p5);

            Product p6 = new Product();
            p6.Name = "Oreo";
            p6.Price = 10000;
            p6.Stock = 10;
            salesList.AddProduct(p6);





            Clients c1 = new Clients();
            c1.Name = "Juan";
            c1.Age = 19;
            c1.Gender = "M";
            salesList.AddClients(c1);


            Clients c2 = new Clients();
            c2.Name = "Diego";
            c2.Age = 25;
            c2.Gender = "M";
            salesList.AddClients(c2);

            Clients c3 = new Clients();
            c3.Name = "Juana";
            c3.Age = 18;
            c3.Gender = "F";
            salesList.AddClients(c3);




            Sales s1 = new Sales();
            s1.Clients = c1;
            s1.Product = p2;
            s1.Product = p6;
            s1.Cantid = 3;
            salesList.AddSale(s1);
            salesList.AddSales(s1);



            Sales s2 = new Sales();
            s2.Clients = c2;
            s2.Product = p1;
            s2.Product = p5;
            s2.Cantid = 4;
            salesList.AddSale(s2);
            salesList.AddSales(s2);

            Sales s3 = new Sales();
            s3.Clients = c3;
            s3.Product = p4;
            s3.Product = p3;
            s3.Cantid = 7;
            salesList.AddSale(s3);
            salesList.AddSales(s3);



            Console.WriteLine("Products");
            salesList.PrintProducts();

            Console.WriteLine("Clients");
            salesList.PrintClients();

            Console.WriteLine("Sales");
            salesList.PrintSales();

            Console.WriteLine("--------------------");


            double totalsales = salesList.TotalVentas();
            Console.WriteLine("Total de ventas: " + totalsales);


            Console.WriteLine("--------------------");


            Sales salemost = salesList.TotalStockC();
            Console.WriteLine("Cliente con la compra importante: " + salemost.Clients.Name);


            Console.WriteLine("--------------------");


            double promedio = salesList.PromedioSales();
            Console.WriteLine("promedio de ventas: " + promedio);


            Console.WriteLine("--------------------");


            Sales moreproduct = salesList.MoreSalesProduc();
            Console.WriteLine($"producto con mas ventas : {moreproduct.Product.Name} -> Cantidad: {moreproduct.Cantid}");


            Console.WriteLine("--------------------");


            Console.WriteLine(" insertar producto:  p2 after p5");
            salesList.InsertarProduct(p2, p5);
            salesList.PrintProducts();

            Console.WriteLine("--------------------");

            Console.WriteLine(" borrar producto: ");
            salesList.BorrarProduct();
            salesList.PrintProducts();

            Console.WriteLine("--------------------");

            Console.WriteLine("insertar cliente: c3 after c2");
            salesList.InsertarClients(c3, c2);
            salesList.PrintClients();


            Console.WriteLine("--------------------");

            Console.WriteLine("borrar cliente: ");
            salesList.BorrarClients();
            salesList.PrintClients();

            Console.WriteLine("--------------------");

        }

    }
}
