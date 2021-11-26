// See https://aka.ms/new-console-template for more information
using _20211126_ToDoApp.Models;
using System.Linq;

Console.WriteLine("Welcome to your toDoList app!");

List<Book> bookList = new List<Book>();
//toDoList = getToDoList();

while (true)
{
    /* sukam programą */
    Console.WriteLine("Choose your command: 'Add', 'List', 'Delete +name'");
    var command = Console.ReadLine().Split(" ");
  
    if (command[0] == "Add")
    {
        Console.WriteLine("Processing command 'Add'");
        Console.WriteLine("--------------------");
        Console.Write("Enter name:");
        var name = Console.ReadLine();
        if (bookList.Where(x => x.Title == name).Count() > 0) {
            Console.WriteLine("Such a book is already in the store");
            goto EndAdd;
        }
        Console.Write("Enter description:");
        var description = Console.ReadLine();
        Console.Write("Enter amount:");
        var amount = Convert.ToInt32(Console.ReadLine());
        bookList.Add(new Book(bookList.Count + 1, amount > 0 ? amount : 0, name, description));

    EndAdd:
        ;
        
    }
    else if (command[0] == "List")
    {
        Console.WriteLine("Processing command 'List'");
        if (bookList.Count > 0)
        {

            bookList.ForEach(toDo =>
            {
                Console.WriteLine(toDo.toListString());
            });
        }
        else
        {
            Console.WriteLine("Your list is empty.");
            
        }
    } else if (command[0] == "Delete") {
        Console.WriteLine("Processing command 'Delete'");
        Console.WriteLine("--------------------");

       

        if (bookList.Count > 0)
        {
            try
            {
                Console.WriteLine("Delete args: " + command[1]);
                bookList.RemoveAt(bookList.IndexOf(bookList.Where(x => x.Title == command[1]).First()));
            }
            catch
            {
                Console.WriteLine("There is no such item");
            }
        } else
        {
            Console.WriteLine("Nothing to delete, your list is empty.");
        }

    } else if (command[0] == "Update"){
        Console.WriteLine("Processing command 'Update'");
        Console.WriteLine("--------------------");
    } else {
        Console.WriteLine("Bye bye!");
        Environment.Exit(0);
    }

}



//public List<ToDo> getToDoList()
//{

//    return ToDoList;
//} 
