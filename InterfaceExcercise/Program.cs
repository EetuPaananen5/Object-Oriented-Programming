// See https://aka.ms/new-console-template for more information
using InterfaceExcercise;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Console.OutputEncoding = System.Text.Encoding.UTF8; //€ näkyy konolissa

//Product puhelin = new Product("Iphone", 900, 50);
//puhelin.ToString();
//Console.WriteLine(puhelin.ToString());

//puhelin.CalculateTotal();
//Console.WriteLine("kappale x hinta on "+puhelin.CalculateTotal());

//puhelin.GetProduct("Iphone");


List<Product> products = new List<Product>()
                {
                new Product("Air Pods", 150, 2),
                new Product("Laturi", 10, 15),
                new Product("Suojakuori", 5, 51),
                };

foreach (Product p in products)
{
    Console.WriteLine(p.ToString());  

   if( p.GetProduct("Laturi") != null)
    {
        Console.WriteLine("Laturi löytyi \n");
        Console.WriteLine("Varaston Arvo: " + p.CalculateTotal());
    }

}

Console.WriteLine("\n\n --------STORE----------\n\n");
Store dna = new Store("DNA", 934000000);
dna.AddProduct(new Product("5G netti", 10, 15));
dna.AddProduct(new Product("Playstation 5", 150, 2));
dna.PrintProducts();



Console.WriteLine("\n\n --------CUSTOMER TEHTÄVÄ----------\n\n");


List<Customer> customer = new List<Customer>()
{
                new Customer("Matti", 900),
                new Customer("Lauri", 2100),
                new Customer("Minni", 3010),
                };

foreach( Customer c in customer)
    
{
    Console.WriteLine(c.ToString());
    Console.WriteLine("bonus on:" + c.GetBonus() + " euroa \n");
    if(c.GetCustomer("Matti")!= null)
    {
        Console.WriteLine("Kutsuttava henkilö on sama");
    }
}





 