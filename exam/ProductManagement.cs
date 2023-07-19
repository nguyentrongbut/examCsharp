using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class ProductManagement
    {
        private List<Product> products = new List<Product>();

        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void AddProduct()
        {
            Console.Write("Enter product ID: ");
            int productID = int.Parse(Console.ReadLine());

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new Product(productID, name, price);
            products.Add(product);

            Console.WriteLine("Product added successfully.");
        }

        private void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
            }
            else
            {
                Console.WriteLine("Product ID\tName\t\tPrice");
                foreach (Product product in products)
                {
                    Console.WriteLine($"{product.ProductID}\t\t{product.Name}\t\t{product.Price}");
                }
            }
        }

        private void DeleteProduct()
        {
            Console.Write("Enter the product ID to delete: ");
            int productID = int.Parse(Console.ReadLine());

            Product product = products.Find(p => p.ProductID == productID);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
