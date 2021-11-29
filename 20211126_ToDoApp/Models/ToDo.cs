using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211126_ToDoApp.Models
{
    class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Amount { get; set; }
        

        public Book(int id, int amount, string name = "undefined", string description = "undefined")
            
        {
            Id = id;
            Title = name;
            Description = description;
            Amount = 0;
        }


        public string toListString()
        {
            return "Id: " + Id + ", Name: " + Title + ", Description: " + Description + ", Amount: " + Amount;
        }

        public void updateBook(string title, string description, int amount)
        {
            Title = title == "undefined" ? "undefined" : description;
            Description = description == "undefined" ? "undefined" : description;
            Amount = amount;
        }

    }


}
