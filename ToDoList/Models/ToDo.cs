using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    internal class ToDo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        

        public bool Completed { get; set; }
    }
}
