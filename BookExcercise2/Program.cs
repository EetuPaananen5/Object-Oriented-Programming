// See https://aka.ms/new-console-template for more information
using BookExcercise2;
using System.Runtime.CompilerServices;

Book kirja1 = new Book("Aapinen", "Maija Mehiläinen", "Otava", 15.50 , "1234567891123") ;

Book kirja2 = new Book("Yön ritari", "Ilkka Remes", "WSOY", 40.00, "1234567891123");


kirja1.GetBookDetails("1234567891123");

Console.WriteLine(" ");
kirja2.GetBookDetails("1234567891123");

Console.WriteLine(" ");

Book.ChangeTheme("komedia");
kirja1.GetBookDetails("1234567891123");
Console.WriteLine(" ");
kirja2.GetBookDetails("1234567891123");

Console.WriteLine(kirja1.Author);




