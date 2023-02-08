using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace SortExercise;

internal class Book : IComparable<Book>
{
    private string name;
    private readonly string author;
    private string publisher;
    private double price;
    private string isbn;
    private static string theme = "Draama";
    private const int MaxLenght = 13;

    public double Price
    {
        get => price;
        set
        {
            if (value > 30)

            {
                price = value * 0.9;
            }

            else
            {
                price = value;
            }

        }
    }

    public string Isbn
    {
        get => isbn;
        set
        {
            if (value.Length == MaxLenght && value.StartsWith("123"))
            {
                isbn = value;
            }
            else
            {
                isbn = "invalid inbd";
            }


        }
    }

    public string Author
    {
        get
        {
            return Author1;
            Console.WriteLine(this.Author1);
        }
    }

    public string Name { get => name; set => name = value; }

    public string Author1 => author;

    public Book(string name, string author, string publisher, double price, string isbn)
    {
        this.Name = name;
        this.author = author;
        this.publisher = publisher;
        this.Price = price;
        this.Isbn = isbn;
    }

    public void GetBookDetails(string tunnus)
    {

        if (tunnus == Isbn)
        {
            Console.WriteLine("Tässä on kirjan tiedot" + "\n " + this.Name + "\n " + this.Author + "\n " + this.publisher + "\n " + this.Price.ToString("0.00") + " Euroa " + "\n " + "Teema on: " + theme + "\n " + "ISBN: " + this.isbn + "\n ");
        }
        else
        {
            Console.WriteLine("Tämän kirjan ISBN tunnus ei täsmää");
        }

    }

    public static void ChangeTheme(string value)
    {
        theme = value;
    }

    public override string? ToString()// tulostaa authorin kautta kirjan tiedot
    {
        return $"ToString metodi kirja {this.Name}, kirjailija {this.Author1}, isbn koodi {this.isbn}, julkaisia {this.publisher}, hinta {this.price} euroa";
    }

    public int CompareTo(Book? other)
    {

        return this.price.CompareTo(other.price);


       /* if (this.price < other.price)   Funktio mikä toimii samal taval ku ylempi
            return -1;
        else if (this.price > other.price)
            return 1;
        else
            return 0;*/

    }
}






