using BookExcercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Literature;

namespace BookExcercise2
{
    internal class Author
    {
        public string name;
        public string birtday;
        private Book book;

        public Author(string name, string birtday)
        {
            this.name = name;
            this.birtday = birtday;
        }

        public Author(string name, string birtday, Book book)
        {
            this.name = name;
            this.birtday = birtday;
            this.Book = book;
            //Console.WriteLine("Kirjan Nimi on " + book.Name);
        }

        internal Book Book
        {
            get
            {
                return book;
            }

            set
            {
                //Console.WriteLine("Vertailu");
               // Console.WriteLine("Kirjan kirjoittaja on " + value?.Author);
               // Console.WriteLine("Kirjailija nimi on  " + this.name);

                if (value?.Author != this.name)
                {
                    Console.WriteLine(" Vertailu: Eri tyypit! eli author ei täsmää this.nameen");
                }
                else if (value?.Author == this.name)
                {
                    book = value;
                }

            }
        }

        public void PrintInformation()
        {

            if (this.book != null)
            {
                Console.WriteLine(" Kirjailija Mätchi! print info: kirjailija " + this.name + ", Kirjailijan syntymäaika " + this.birtday + ",  Kirjan nimi " + this.book.Name + ", kirjailijan nimi " + this.book.Author + ", hinta " + this.book.Price + ", isbn koodi " + this.book.Isbn);
            }
            else
            { 
                Console.WriteLine(" Ei löydy täsmäävää kirjailijaa, annettu lähtö arvo on: nimi " + this.name + ", syntymäaika " + this.birtday  );
                
            }

        }



    }
}
