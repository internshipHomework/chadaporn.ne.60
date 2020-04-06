using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace work09
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
        string filename = @"product.csv";
        List<IProduct> ProductsAll = new List<IProduct>();
        public void AddProductToCart(string product)
        {
            List<string> lines = File.ReadAllLines(filename).ToList();
            foreach(var line in lines)
            {
                string[] values = line.Split(',');
                IProduct addProduct = new SubProduct();
                addProduct.SKU = values[0];
                addProduct.Name = values[1];
                addProduct.Price = values[2];
                ProductsAll.Add(addProduct);
            }

            double sum = 1;
            int count = 1;
            while ( count <= 100 ) {
                Console.WriteLine("Please input a product key:");
                IEnumerable<IProduct> Allproduct = from llist in ProductsAll where llist.SKU == product select llist ;
                Console.WriteLine("Products in your cart are");
                foreach (var products in Allproduct)
                {
                    myAl.Add( count+ "." + products.Name +"  "+ products.Price);
                    double pricedouble = Convert.ToDouble(products.Price);
                    sum += pricedouble;
                }
                
                for(int k = 0 ; k< myAl.Count; k++){
                        Console.WriteLine(myAl[k]);
                    }
                Console.WriteLine("----------"); 
                Console.WriteLine("Total amount: "+ sum + " Bath");
                product = Console.ReadLine();

                count++;
            }
        }

        public void AddProductToCart(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()  
        {
            return ProductsAll;
        }
        public IEnumerable<IProduct> GetProductsInCart()
        {
            return ProductsAll;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products in your cart are");
            Console.WriteLine("none");
            Console.WriteLine("----------");
            Console.WriteLine("Total amount: 0.00 Bath");
            SubHom panel2 = new SubHom();
            Console.WriteLine("Please input a product key:");
            string a = Console.ReadLine();
            panel2.AddProductToCart(a);
        }
    }

    
}