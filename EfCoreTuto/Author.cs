using System;
using System.Collections.Generic;
using System.Collections; 
namespace EfCoreTuto
{
    public class Author
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public List<BookAuthor> bookauthor{get; set;} = new List<BookAuthor>();
    }
}