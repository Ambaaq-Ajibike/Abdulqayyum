using System;

namespace Number15
{
    public class Test
    {
        public static void Menu()
        {
            System.Console.WriteLine("How many books did you want to save in the library");
            int NumberofBooks = int.Parse(Console.ReadLine());            
            for (var i = 0; i < NumberofBooks; i++)
            {
                 System.Console.WriteLine("Enter the book title");
                string title = Console.ReadLine();        
                System.Console.WriteLine("Enter the book Author");
                string author = Console.ReadLine(); 
                System.Console.WriteLine("publisher name");
                string publisher = Console.ReadLine(); 
               System.Console.WriteLine("Enter the Internatonal Standard book number");
                int isbn = int.Parse(Console.ReadLine()); 
                Library library = new Library(title, author, publisher, DateTime.Now, isbn);
            }
            Library.PrintBookInfo(); 
            System.Console.WriteLine("Enter the author name of the book you want to delete");
            string BookToDelete = Console.ReadLine();
           foreach (var item in Library.books)
           {
               if (item.Author == BookToDelete)
               {
                   Library.DeleteBook(item.Author);
               }
           }          

        }    
    }
}
 