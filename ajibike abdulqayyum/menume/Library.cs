using System;

namespace Number15
{
    public class Library : Books
    {
        public const string LibraryName = "Ambaaq Library";    
        public static List<Books> books = new List<Books>();
        public Library(string title, string author, string publisher, DateTime releasedDate, int isbn) : base(title, author, publisher, releasedDate, isbn)
        {
            AddBooks();
        }
        public void AddBooks()
        {
            books.Add(this);
        }
        public void BookSearch()
        {
            for (var i = 0; i < books.Count; i++)
            {
                Console.WriteLine($" Book TiTle: {books[i].Title} Author: {books[i].Author}");
            }
        }
        public static void PrintBookInfo()
        {
           for(int i = 0; i < books.Count; i ++)
           {
               System.Console.WriteLine($"The title of book {i + 1} is {books[i].Title}, it was written by {books[i].Author} the was released on {DateTime.Now} it International Book Number is {books[i].ISBN}");
           }
        }
        public static void DeleteBook(string name)
        {
            foreach (var item in books)
            {
                if(item.Title == name)
                {
                    books.Remove(item);
                }
                
            }
        }


    }
}
