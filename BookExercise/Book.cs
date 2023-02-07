using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookExercise
{
    internal class Book
    {

        string title;
        string author;
        string id;
        double price;
        int pageCount;



        public Book()
        {
            this.title = "";
            this.author = "";
            this.id = "00000";
            this.price = 19.90;
            this.pageCount = 0;
            this.MyMethod(this.pageCount, this.title);


        }

        public Book(string title, int pageCount)
        {
            this.title = title;
            this.pageCount = pageCount;

            this.author = "";
            this.id = "00000";
            this.price = 19.90;

            this.MyMethod(this.pageCount, this.title);
        }

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.SetId(id);
            this.price = price;

            //this.MyMethod2(this.title, this.author, this.id, this.price);
            this.PrintData();
        }



        public void MyMethod2(string author, string kirjailia, string idee, double parameterPrice)
        {
            Console.WriteLine("this is " + author + " author is " + kirjailia + " id is " + idee + " price is " + parameterPrice + " dollars");
        }

        public void SetId(string id)
        {
            if (id.Length != 5)
            {
                Console.WriteLine("invalid id");
                this.id = "Error";
            }
            else
            {
                this.id = id;
            }

        }

        public void PrintData()
        {
            Console.WriteLine("title {0}\n" + "author {1}\n" + "id {2}\n" + "price {3}\n", this.title, this.author, this.id, this.price);
        }
        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("Sivu määrä on {0}, " +
            "title is {1}",
            parameter1, parameter2);
        }

        public void CompareBooks(Book other)
        {
            Console.WriteLine();
            Console.WriteLine("Kirjojen hinta vertailu:");
            Console.WriteLine("book name: " + this.title + " hinta: " + this.price);
            Console.WriteLine("book name: " + other.title + " hinta: " + other.price);
            if (this.price > other.price)
            {
                Console.WriteLine("Tämä kirja: " + this.title + " on siis kallinpi ja sen hinta on: " + this.price);

            }
            else
            {
                Console.WriteLine("book price: " + other.price);
            }





        }

    }
}
