using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookExcercise2
{
    internal class Book
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
                if(value.Length == MaxLenght && value.StartsWith("123"))
                {
                    isbn= value;
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
                return author;
                Console.WriteLine(this.author);
            }
        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            this.Isbn = isbn;
        }

        public void GetBookDetails(string tunnus)
        {

            if (tunnus == Isbn)
            {
                Console.WriteLine("Tässä on kirjan tiedot" + "\n " + this.name + "\n " + this.Author + "\n " + this.publisher + "\n " + this.Price.ToString("0.00") + "\n " + "Teema on" + "\n " + theme);
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
    }






}
