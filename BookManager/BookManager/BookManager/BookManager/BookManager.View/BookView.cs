using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Models;
using BookManager.Data;

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
                return userinput;
        }
    }
    public class CreateView
    {  
        public string createNewBookTitle()
        {
            Console.Clear();
            Console.WriteLine("Create a Book");
            Console.WriteLine("------------------");

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
    }
    public class DisplayView
    {
        public string displaybooks()
        {
            Console.Clear();
            Console.WriteLine("Books within the Repository:  ");
            Console.WriteLine("------------------");

            //TODO update after creating BookRepository, list bookID and Title elements
            string bookList = "";
            return bookList;   
        }
    }
    public class SearchView
    {
        public int searchbook()
        {
            Console.WriteLine("What is the Book ID?");
            Console.Write("\n   ");
            int searchBookID = int.Parse(Console.ReadLine());
            return searchBookID;
        }
    }
    public class EditView
    {
        public int editbook()
        {
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
            Console.WriteLine("What is the Book ID to delete?");
            Console.Write("\n   ");
            
            int removeBookID = int.Parse(Console.ReadLine());
            return removeBookID;
        }
    }
}

