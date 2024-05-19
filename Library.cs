using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW___Books
{
    public class Library
    {
        private List<Book> books;

        public Library() 
        {
           books = new List<Book>(); 
        }

        public int Count => books.Count;

        public Book this[int index]
        {
            get => books[index];
            set => books[index] = value;
        }

        public Book this[string name] 
        {
            get => books.Find(book => book.Name == name);
        }

        public void AddBook(Book book)      
        {
            books.Add(book);
        }
        public bool RemoveBook(string name)  
        {
            var book = books.Find(book => book.Name == name);
            if(book != null) 
            {
                return books.Remove(book);
            }
            return false;                
        }

        public bool ContainsBook(string name) 
        {
            return books.Exists(book => book.Name == name);
        }

        public static Library operator +(Library list, Book book)
        {
            list.AddBook(book);
            return list;
        }
        public static Library operator -(Library list, string name) 
        {
            list.RemoveBook(name);
            return list;
        }
        public void Print()
        {
            for (int i = 0; i < books.Count; i++) 
            {
                Console.WriteLine($"Книга: {books[i].Name}, автор {books[i].Author}");
            }
        }

    }
}
