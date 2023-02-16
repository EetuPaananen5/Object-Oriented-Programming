// See https://aka.ms/new-console-template for more information
using FilesExercise;
using Newtonsoft.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Files Exercise!\n");

Console.WriteLine();

const string FilePath= @"C:\Users\Eetu Paananen\source\repos\Object-Oriented-Programming\FilesExercise\myBooks.json";

FileManager fm = new FileManager(FilePath);

//Console.WriteLine(fm.ReadWords());

// Luetaan mybooks json tiedosto ja deserialisoidaan  se lisaksi book olioita'

List<Book>? books = JsonConvert.DeserializeObject<List<Book>>(fm.ReadWords());



//foreach (Book currentbook in books)
//{
//    Console.WriteLine(currentbook.ToString());
//}

//Lisätään muutama kirja
books.Add(new Book(" Nyrkki1 ", " Ilkka Remes ", 15.50));
books.Add(new Book("Nyrkki2 ", " Ilkka Remes2 ", 14.50));
books.Add(new Book(" Nyrkki3 ", " Ilkka Remes3 ", 5.50));
books.Add(new Book(" Kirja1 ", " Eetu Paananen ", 100));
books.Add(new Book(" Nyrkki4 ", " Ilkka Remes4 ", 18.50));


//Serialisoidaan lista ja tallennetaan se mybooks json tiedostoon

File.WriteAllText(FilePath, JsonConvert.SerializeObject(books));


foreach (Book currentbook in books)
{
    Console.WriteLine(currentbook.ToString()+"\n");
}
