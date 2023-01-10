using System;
using System.Collections.Generic;
using System.Linq;
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
            this.pageCount = 0;

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

            this.MyMethod2(this.title, this.author, this.id, this.price);
        }

   

        public void MyMethod2(string author, string kirjailia, string idee, double parameterPrice)
        {
            Console.WriteLine( "this is " + author + " author is " + kirjailia + " id is " + idee + " price is " + parameterPrice + " dollars");
        }

        public void SetId(string id)
        {
            if(id.Length != 5)
            {
                Console.WriteLine("invalid id");
                this.id = "Error";
            }
            else
            {
                this.id=id;
            }
            
        }

        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("page count is {0}, " +
            "title is {1}",
            parameter1, parameter2);
        }

     


    }
}
