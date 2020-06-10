using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Models;
using BookManager.Data;
using BookManager;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BookManager.View
{
    public class BookView
    {

        public string mainMenu()
        {
            Console.Clear();
            Console.WriteLine("<Book> Manager");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Create a Book.");
            Console.WriteLine("2. List all of the Books.");
            Console.WriteLine("3. Find a Book by ID.");
            Console.WriteLine("4. Edit a Book.");
            Console.WriteLine("5. Remove a Book.");

            Console.WriteLine("\nQ to quit");
            Console.Write("\nEnter selection:  ");

            string userinput = Console.ReadLine().ToUpper();
            if (string.IsNullOrEmpty(userinput))
            {
                Console.WriteLine("Please try again.");
                Console.ReadLine();
                mainMenu();
            }

            return userinput;
        }

    }
    public class CreateView
    {
        bool isTitleValid;
        bool isQuantityValid;
        
        string createBookTitle;
        int createBookQuantity;
        decimal createBookPrice;
        public void createNewBookInto()
        {
            Console.Clear();
            Console.WriteLine("Create a Book");
            Console.WriteLine("------------------");
        }
        public void checkNewBookTitle()
        {
            Console.WriteLine("What is the Book Title?");
            Console.Write("\n   ");
            string checkBookTitle = Console.ReadLine();
            isBookTitleValid(checkBookTitle);
            if (isTitleValid != false)
            {
                createBookTitle = checkBookTitle;
                createNewBookTitle();
            }
            else
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");
                checkNewBookTitle();
            }
        }
        private void isBookTitleValid(string checkBookTitle)
        {
            if (string.IsNullOrEmpty(checkBookTitle))
            {
                isTitleValid = false;
            }
            else
            {
                isTitleValid = true;
            }
        }
        
        public string createNewBookTitle()
        {
            return createBookTitle;
        }
        public void checkNewBookQuantity()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("What is the Quantity of Books available?  Cannot be 0 or negative. ");
            Console.Write("\n   ");
            string incomingBookQuantity = Console.ReadLine();

            isBookQuantityValid(incomingBookQuantity);
        }
        private void isBookQuantityValid(string incomingBookQuantity)
        {
            if (string.IsNullOrEmpty(incomingBookQuantity))
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");
                
                checkNewBookQuantity();
            }
            else
            {
                int.TryParse(incomingBookQuantity, out createBookQuantity);
            }
            if (createBookQuantity <=0)
            { 
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkNewBookQuantity();
            }
            else
            {
                createNewBookQuantity();
            }
        }
        public int createNewBookQuantity()
        {
            return createBookQuantity;
        }

        public void checkNewBookPrice()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("What is the Book price? ");
            Console.Write("\n   ");
            string incomingBookPrice = Console.ReadLine();

            isBookPriceValid(incomingBookPrice);
        }
        private void isBookPriceValid(string incomingBookPrice)
        {
            if (string.IsNullOrEmpty(incomingBookPrice))
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkNewBookPrice();
            }
            else
            {
                decimal.TryParse(incomingBookPrice, out createBookPrice);
            }
            if (createBookPrice <= 0)
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkNewBookPrice();
            }
            else
            {
                createNewBookPrice();
            }
        }


        public decimal createNewBookPrice()
        {
            return createBookPrice;
        }
        public void createBookSuccess(bool createBookSuccess)
        {
            Console.WriteLine(createBookSuccess);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
    public class DisplayView
    {
        public void displayViewMenu()
        {
            Console.Clear();
            Console.WriteLine("Books within the Repository:  ");
            Console.WriteLine("------------------");
        }
        public void displaybooks(int bookID, string bookTitle)
        {
            Console.WriteLine("Book ID:  " + bookID + "  Book Title:  " + bookTitle);
        }
        public void toMainMenu()
        {
            Console.WriteLine("Press Enter for Main Menu");
            Console.ReadKey();
        }
    }
    public class SearchView

    {
        int searchBookID;
        public void checkSearch()
        {
            Console.WriteLine("What is the Book ID?  0 - 5");
            Console.Write("\n   ");
            string incomingSearch = Console.ReadLine();

            isSearchValid(incomingSearch);
        }

        private void isSearchValid(string incomingSearch)
        {
            
            if (string.IsNullOrEmpty(incomingSearch))
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkSearch();
            }
            else
            {
                int.TryParse(incomingSearch, out searchBookID);
            }
            if (searchBookID < 0 || searchBookID > 5)
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkSearch();
            }
            else
            {
                searchBook();
            }
        }

        public int searchBook()
        {
            
            return searchBookID;
        }

        public void searchBooksReturn(int bookID, string bookTitle, decimal bookPrice, int bookQuantity)
        {
            Console.WriteLine("Book ID:  " + bookID);
            Console.WriteLine("Book Title:  " + bookTitle);
            Console.WriteLine("Book Price:  " + string.Format("{0:c2}", bookPrice));
            Console.WriteLine("Book Quantity:  " + bookQuantity);
            Console.WriteLine("");

            Console.WriteLine("Press Enter for Main Menu");
            Console.ReadKey();
        }
    }
    public class EditView
    {
        int editBookID;
        public void checkEdit()
        {
            Console.WriteLine(" ");
            Console.WriteLine("What is the Book ID to edit?");
            Console.Write("\n   ");
            string incomingEdit = Console.ReadLine();

            isEditValid(incomingEdit);

        }
        private void isEditValid(string incomingEdit)
        {

            if (string.IsNullOrEmpty(incomingEdit))
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkEdit();
            }
            else
            {
                int.TryParse(incomingEdit, out editBookID);
            }
            if (editBookID < 0 || editBookID > 5)
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkEdit();
            }
            else
            {
                editbook();
            }
        }
        public int editbook()
        {
            return editBookID;
        }
    }
    public class RemoveView
    {
        int removeBookID;
        public void checkRemove()
        {
            Console.WriteLine(" ");
            Console.WriteLine("What is the Book ID to remove?");
            Console.Write("\n   ");
            string incomingRemove = Console.ReadLine();

            isRemoveValid(incomingRemove);

        }
        private void isRemoveValid(string incomingRemove)
        {

            if (string.IsNullOrEmpty(incomingRemove))
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkRemove();
            }
            else
            {
                int.TryParse(incomingRemove, out removeBookID);
            }
            if (removeBookID < 0 || removeBookID > 5)
            {
                Console.WriteLine("Please try again.");
                Console.WriteLine("");

                checkRemove();
            }
            else
            {
                removebook();
            }
        }

        public int removebook()
        {
            return removeBookID;
        }
    }

}