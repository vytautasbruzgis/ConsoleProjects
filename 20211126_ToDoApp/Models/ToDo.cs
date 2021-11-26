using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211126_ToDoApp.Models
{
    class ToDo
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; } = false;

        public ToDo(int id, string name = "undefined", string description = "undefined")
            
        {
            Id = id;
            Name = name;
            Description = description;
        }


        public string toListString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Description: " + Description;
        }

    }


}
