using BookExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        Book myFirstBook = new Book();
        Book mySecondBook = new Book("Peppi Pitkätossu", 77);
        Book myThirdBook = new Book("HarryPotter", 22);
        Book myBook = new Book("Muumit", "tove janson", "12345", 15.00);
        Book myBook2 = new Book("Muumit", "tove janson", "123456", 15.00);


    }
    
}
