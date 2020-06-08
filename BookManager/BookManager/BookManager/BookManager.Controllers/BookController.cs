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
        

        public void Start()
        {
            bookView = new BookView();
            bookRepository = new BookRepository(10);

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

                case "Q":
                    return;
            }

        }
        public void createBook()
        {
            
            //TODO create validation when created
            
            createView = new CreateView();
            string createBookTitle = createView.createNewBookTitle();
            int createBookQuantity = createView.createNewBookQuantity();
            decimal createBookPrice = createView.createNewBookPrice();

            bookRepository.CreateBook(createBookTitle,createBookQuantity,createBookPrice);

        }
        public void displayBooks()
        {
            //TODO retrieve bookrepository element book title
            //TODO display result
            displayView = new DisplayView();
            string bookList = displayView.displaybooks();

            Console.ReadLine();

        }
        public void searchBooks()
        {
            //TODO make console for input BookID
            //TODO search bookID match from that element of bookrepository
            //TODO display search result
            searchView = new SearchView();
            int searchBookID = searchView.searchbook();

        }
        public void editBook()
        {
            //TODO call displayBooks
            //TODO make console which book to edit by BookID, user input
            // TODO create validation when edited
            editView = new EditView();
            int editBookID = editView.editbook();

        }
        public void removeBook()
        {
            //TODO call displayBooks
            //TODO make console which book to remove by BookID, user input  

            removeView = new RemoveView();
            int removeBookID = removeView.removebook();
        }
        
}
}
