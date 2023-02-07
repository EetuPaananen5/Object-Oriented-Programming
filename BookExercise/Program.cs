using BookExercise;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

      //  Book myFirstBook = new Book();
        Book mySecondBook = new Book("Peppi Pitkätossu", 77);
        Book myThirdBook = new Book( "HarryPotter", 22);

        Book myBook = new Book("Muumit", "tove janson", "12345", 20.00);
        Book myBook2 = new Book("Rauta nyrkki", "Ilkka Remes", "123456", 16.00);
        myBook.CompareBooks(myBook2);

    }

    
}
