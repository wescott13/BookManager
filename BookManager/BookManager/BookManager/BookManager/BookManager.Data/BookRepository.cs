using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.Data
{
    public class BookRepository : Book
    {
        int _booksInRepository;
        public Book[] _books;
        int _currentIndex;

        public void CreateBook(string createBookTitle, int createBookQuantity, decimal createBookPrice)
        {
            Book newBook = new Book();
            newBook.BookTitle = createBookTitle;
            newBook.BookQuantity = createBookQuantity;
            newBook.BookPrice = createBookPrice;
            newBook.BookID = _currentIndex;
            AddBookToArray(newBook);
        }

        public BookRepository(int booksInRepository)
        {
            _booksInRepository = booksInRepository;
            _books = new Book[booksInRepository];
            _currentIndex = 0;
        }

        private void AddBookToArray(Book AddBook)
        {
            _books[_currentIndex] = AddBook;
            _currentIndex++;
        }


    }
}
