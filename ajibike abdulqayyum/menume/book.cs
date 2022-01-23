using System;

namespace Number15
{
    public class Books
    {
       public string Title{get; set;}
       public string Author{get; set;}
       public string Publisher{get; set;}
       public DateTime ReleasedDate{get;}
       public int ISBN{get; set;}
       public Books(string title, string author, string publisher, DateTime releasedDate, int isbn)
       {
           Title = title;
           Author = author;
           Publisher = publisher;
           ReleasedDate = releasedDate;
           ISBN = isbn;
       }
    }
}
