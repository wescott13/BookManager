using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public decimal BookPrice { get; set; }
        public int BookQuantity { get; set; }

        public void SetTitle(string newTitle)
        {
            BookTitle = newTitle;
        }
        public string GetTitle()
        {
            return BookTitle;
        }
        public void SetPrice(decimal newPrice)
        {
            BookPrice = newPrice;
        }
        public decimal GetPrice()
        {
            return BookPrice;
        }
        public void SetQuantity(int newQuantity)
        {
            BookQuantity = newQuantity;
        }
        public int GetQuantity()
        {
            return BookQuantity;
        }
        public void SetBookID(int newBookID)
        {
            BookID = newBookID;
        }
        public int GetBookID()
        {
            return BookID;
        }
    }

}
