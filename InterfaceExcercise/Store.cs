using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal class Store : IProducts, ICustomers
    {
        private string name;
        private double revenue;
        private List<Product> storeProducts = new List<Product>();
        private List<Customer> storeCustomers = new List<Customer>();


        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        public void AddCustomer(Customer customer)
        {
            this.storeCustomers.Add(customer);
        }
        public void PrintCustomers()
        {
            Console.WriteLine("tähän printataan asiakkaat" + this.storeCustomers)
;        }

        public void AddProduct(Product product)
        {
            this.storeProducts.Add(product);
        }

        
        public void PrintProducts()
        {

            // tulostaa tuotteiden lukumäärän,
            Console.WriteLine("Tuotteiden lukumäärä: "+ this.storeProducts.Count);

            // tulostaa joka tuotteen tiedot kutsumalla calculatetotal()
            foreach(Product product in this.storeProducts)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine("Varaston arvo on: " + product.CalculateTotal());
            }
        }
    }
}
