// See https://aka.ms/new-console-template for more information
using SortExercise;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Book> books = new List<Book>();
        books.Add(new Book("muumit ", "Astrid Lingren ", "WSOY ", 20.00, "1234567891234"));
        books.Add(new Book("Eetu kirja ", "Eetu Paananen ", "Otava ", 12.99, "1234567891123"));
        books.Add(new Book("Konna1 ", "Sami Jokinen ", "Otava ", 10.90, "1234567891123 "));
        
        //tulostaa kirjat enne sorttaust
        foreach(Book book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\n\n --------väli----------\n\n");

        books.Sort();

        // Tulostaa sorttauksen jälkeen oikeassa järjestyksessä

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
}