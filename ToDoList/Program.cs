using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Models;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDo todo1 = new();

            todo1.Name = "Clean room";
            todo1.Description = "Reikėtų išplauti grindis";
            todo1.Completed = false;

            ToDo todo2 = new()
            {
                Name = "Watch Žalgiris",
                Description = "...",
                Completed = false
            };



            var todos = new List<ToDo>();
            todos.Add(todo1);
            todos.Add(todo2);
            todos.Add(new ToDo());

            todos.GetEnumerator().MoveNext();

            todos.Where(t => t.Completed == true);

        }
    }
}
