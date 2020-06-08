using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Models;
using BookManager.Data;
using BookManager;
using System.Globalization;

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
            
            string userinput = Console.ReadLine();
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
        public void createNewBookInto()
        {
            Console.Clear();
            Console.WriteLine("Create a Book");
            Console.WriteLine("------------------");
        }
        public string createNewBookTitle()
        {
            Console.WriteLine("What is the Book Title?");
            Console.Write("\n   ");
            string createBookTitle = Console.ReadLine();
            return createBookTitle;
        }
        public int createNewBookQuantity()
        {
            Console.WriteLine("------------------");

            Console.WriteLine("What is the Quantity of Books available? ");
            Console.Write("\n   ");
            int createBookQuantity = int.Parse(Console.ReadLine()); 
            return createBookQuantity;
        }
        public decimal createNewBookPrice()
        {
            Console.WriteLine("------------------");

            Console.WriteLine("What is the Book price? ");
            Console.Write("\n   ");
            decimal createBookPrice = decimal.Parse(Console.ReadLine());
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
            Console.WriteLine("Book ID:  "+ bookID + "  Book Title:  " + bookTitle);
        }
        public void toMainMenu()
        {
            Console.WriteLine("Press Enter for Main Menu");
            Console.ReadKey();
        }
    }
    public class SearchView
    {
        public int searchBook()
        {
            Console.WriteLine("What is the Book ID?  0 - 5");
            Console.Write("\n   ");
            int searchBookID = int.Parse(Console.ReadLine());
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
        public int editbook()
        {
            Console.WriteLine(" ");
            Console.WriteLine("What is the Book ID to edit?");
            Console.Write("\n   ");
            int editBookID = int.Parse(Console.ReadLine());
            return editBookID;
        }
    }
    public class RemoveView
    {
        public int removebook()
        {
            Console.WriteLine(" ");
            Console.WriteLine("What is the Book ID to delete?");
            Console.Write("\n   ");
            
            int removeBookID = int.Parse(Console.ReadLine());
            return removeBookID;
        }
    }
    
}

