using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryICT
{
    public class Library
    {
        private string _name;
        private List<Book> _bookList;

        public Library()
        {

        }

        public string Name;
        public List<Book> BookList;
        public Library(string _name, List<Book> _bookList)
        {
            Name = _name;
            BookList = _bookList;

        }

        public void addBookToLibrary(Book book)
        {
            //book = new Book();
            //Book b = new Book();
            //b=Book.CreateBook()
            BookList.Add(book);
            
        }

        public bool RemoveBookFromLibrary(string catalogNo)
        {
            Book book = new Book();
            if (book.CatalogNo == catalogNo)
            {
                BookList.Remove(book);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void DisplayBooks()
        {
            var check = BookList.Any();
            if (check)
            {
                
                foreach (Book i in BookList)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("No books to show");
            }
            
        }
    }
}
