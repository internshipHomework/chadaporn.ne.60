using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myapp
{
    public interface IHomework09
    {
        IEnumerable<IProduct> GetAllProducts();
        void AddProductToCart(IProduct product);
        IEnumerable<IProduct> GetProductsInCart();
    }
    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        string Price { get; set; }
    }

    public class SubProduct : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

    }

    public class SubHom : IHomework09
    {
        ArrayList myAl = new ArrayList();
        string filepath = @"product.csv";
        List<IProduct> IProductList = new List<IProduct>();
        public void AddProductToCart(string product)
        {
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                IProduct newIProduct = new SubProduct();
                newIProduct.SKU = entries[0];
                newIProduct.Name = entries[1];
                newIProduct.Price = entries[2];
                IProductList.Add(newIProduct);
            }

            ArrayList ProductName = new ArrayList();
            ArrayList ProductPrice = new ArrayList();
            int sum = 0;

            do
            {

                Console.Write("Please input a product key:  ");
                string inputSKU = Console.ReadLine();
                for (int i = 0; i < SKU.Count; i++)
                {
                    if (inputSKU == SKU[i])
                    {
                        ProductName.Add(Name[i]);
                        ProductPrice.Add(Price[i]);
                        string v = Price[i];
                        int x = Convert.ToInt32(v);
                        sum = sum + x;
                    }
                }

                Console.WriteLine("Products in your cart are: ");

                for (int iii = 1; iii <= ProductName.Count; iii++)
                {
                    if (iii <= ProductName.Count)
                    {
                        int Number = Convert.ToInt32(iii);
                        int Order = Number - 1;

                        Console.WriteLine(Number + ". " + ProductName[Order] + "  " + ProductPrice[Order]);
                    }
                    else
                    {
                        Console.WriteLine("none");
                    }

                }
                Console.WriteLine("----------------------");
                Console.WriteLine("Total amount: " + sum + " Baht");
                // Console.Write(sum + " Bath");

            } while (true);
        }

        public void AddProductToCart(IProduct product)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            return IProductList;
        }
        public IEnumerable<IProduct> GetProductsInCart()
        {
            return IProductList;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Products in your cart are");
            // Console.WriteLine("none");
            // Console.WriteLine("----------");
            // Console.WriteLine("Total amount: 0.00 Bath");
            SubHom panel2 = new SubHom();
            Console.WriteLine("Please input a product key:");
            string a = Console.ReadLine();
            panel2.AddProductToCart(a);
        }
    }


}