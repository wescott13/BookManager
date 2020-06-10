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
        private Book[] _books;
        int _currentIndex;
        public bool createSuccess;
        int _bookRepositoryLimit;

        public void CreateBook(string createBookTitle, int createBookQuantity, decimal createBookPrice)
        {
            Book newBook = new Book();
            newBook.BookTitle = createBookTitle;
            newBook.BookQuantity = createBookQuantity;
            newBook.BookPrice = createBookPrice;
            newBook.BookID = _currentIndex;
            AddBookToArray(newBook);
        }
        public BookRepository(int bookRepositoryLimit)
        {
            _bookRepositoryLimit = bookRepositoryLimit;
            _books = new Book[bookRepositoryLimit];
            _currentIndex = 0;

            Book b0 = new Book();
            b0.SetTitle("Alpha");
            b0.SetPrice(1);
            b0.SetQuantity(2);
            b0.SetBookID(_currentIndex);
            AddBookToArray(b0);

            Book b1 = new Book();
            b1.SetTitle("Beta");
            b1.SetPrice(2);
            b1.SetQuantity(4);
            b1.SetBookID(_currentIndex);
            AddBookToArray(b1);

            Book b2 = new Book();
            b2.SetTitle("Gamma");
            b2.SetPrice(4);
            b2.SetQuantity(8);
            b2.SetBookID(_currentIndex);
            AddBookToArray(b2);

            Book b3 = new Book();
            b3.SetTitle("Delta");
            b3.SetPrice(8);
            b3.SetQuantity(16);
            b3.SetBookID(_currentIndex);
            AddBookToArray(b3);
        }
        private void AddBookToArray(Book AddBook)
        {
            createSuccess = false;
            while (_bookRepositoryLimit > _currentIndex)
            {
                for (int i = 0; i < _books.Length; i++)
                    _books[_currentIndex] = AddBook;
                _currentIndex++;
                createSuccess = true;
                break;
            }
        }
        public bool CreateBookSuccess()
        {
            return createSuccess;
        }
        public Book[] BooksInRepository()
        {
            return _books;
        }
        public void EditBook(int editBookID, string createBookTitle, int createBookQuantity, decimal createBookPrice)
        {
            Book newBook = new Book();
            newBook.BookTitle = createBookTitle;
            newBook.BookQuantity = createBookQuantity;
            newBook.BookPrice = createBookPrice;
            newBook.BookID = editBookID;

            EditBookInArray(newBook);
        }
        private void EditBookInArray(Book EditBook)
        {
            createSuccess = false;
            _currentIndex = EditBook.BookID;
            _books[_currentIndex] = EditBook;
            createSuccess = true;
        }

        public void RemoveBook(int removeBookID)
        {
            _books[removeBookID] = null;
        }
       
}



}

