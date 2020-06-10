using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Models;
using BookManager.Data;
using BookManager.View;

namespace BookManager.Controllers
{
    public class BookController
    {
        private BookView bookView;
        private CreateView createView;
        private DisplayView displayView;
        private SearchView searchView;
        private EditView editView;
        private RemoveView removeView;
        private BookRepository bookRepository;

        int x = 6;  //BookRepositoryLimit
        public void Start()
        {
            bookRepositoryLimit();
            bookRepository = new BookRepository(x);
            MainMenu();
        }
        public int bookRepositoryLimit()
        {
            int bookRepositoryLimit = x;
            return bookRepositoryLimit;
        }
        public void MainMenu()
        {
            bookView = new BookView();
            string userinput = bookView.mainMenu();

            switch (userinput)
            {
                case "1":
                    createBook();
                    break;
                case "2":
                    displayBooks();
                    break;
                case "3":
                    searchBooks();
                    break;
                case "4":
                    editBook();
                    break;
                case "5":
                    removeBook();
                    break;
                default:
                    MainMenu();
                    break;
                case "Q":
                    return;
            }
        }
        public void createBook()
        {
            createView = new CreateView();
            createView.createNewBookInto();
            createView.checkNewBookTitle();
            createView.checkNewBookQuantity();
            createView.checkNewBookPrice();

            string createBookTitle = createView.createNewBookTitle();
            int createBookQuantity = createView.createNewBookQuantity();
            decimal createBookPrice = createView.createNewBookPrice();

            bookRepository.CreateBook(createBookTitle, createBookQuantity, createBookPrice);
            validation();

            MainMenu();
        }
        public void validation()
        {
            bool createBookSuccess = bookRepository.CreateBookSuccess();
            createView.createBookSuccess(createBookSuccess);
        }
        public void displayBooks()
        {
            displayView = new DisplayView();
            displayView.displayViewMenu();

            Book[] _books;
            _books = bookRepository.BooksInRepository();
            
            displayView.displaybooks(_books);
            displayView.toMainMenu();
            MainMenu();
        }
        public void searchBooks()
        {
            searchView = new SearchView();
            searchView.checkSearch();

            int searchBookID = searchView.searchBook();

            Book returnBook = bookRepository.SearchBook(searchBookID);

            if (returnBook != null)
            {
                int bookID = returnBook.BookID;
                string bookTitle = returnBook.BookTitle;
                int bookQuantity = returnBook.BookQuantity;
                decimal bookPrice = returnBook.BookPrice;
                searchView.searchBooksReturn(bookID, bookTitle, bookPrice, bookQuantity);
            }

            MainMenu();
        }
        public void editBook()
        {
            displayView = new DisplayView();

            Book[] _books;
            _books = bookRepository.BooksInRepository();
            displayView.displaybooks(_books);

            editView = new EditView();
            editView.checkEdit();

            int editBookID = editView.editbook();
            createView = new CreateView();
            createView.checkNewBookTitle();
            createView.checkNewBookQuantity();
            createView.checkNewBookPrice();

            string createBookTitle = createView.createNewBookTitle();
            int createBookQuantity = createView.createNewBookQuantity();
            decimal createBookPrice = createView.createNewBookPrice();

            bookRepository.EditBook(editBookID, createBookTitle, createBookQuantity, createBookPrice);
            validation();
            displayBooks();
        }
        public void removeBook()
        {
            displayView = new DisplayView();

            Book[] _books;

            _books = bookRepository.BooksInRepository();
            displayView.displaybooks(_books);

            removeView = new RemoveView();
            removeView.checkRemove();
            int removeBookID = removeView.removebook();

            bookRepository.RemoveBook(removeBookID);

            displayBooks();
        }
    }
}
