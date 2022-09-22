using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 12;
            product1.ProductName = "çılgın bedis";
            product1.UnıtPrace = 500;
            product1.UnitsİnStock = 23;

            ProductManager productManager= new ProductManager();
            productManager.Add();


        }
    }
}
