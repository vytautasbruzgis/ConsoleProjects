// See https://aka.ms/new-console-template for more information
using _20211126_ToDoApp.Models;
using System.Linq;

Console.WriteLine("Welcome to your toDoList app!");

List<ToDo> toDoList = new List<ToDo>();
//toDoList = getToDoList();

while (true)
{
    /* sukam programą */
    Console.WriteLine("Choose your command: 'Add', 'List'");
    var command = Console.ReadLine().Split(" ");
  
    if (command[0] == "Add")
    {
        Console.WriteLine("Processing command 'Add'");
        Console.WriteLine("--------------------");
        Console.Write("Enter name:");
        var name = Console.ReadLine();
        Console.Write("Enter description:");
        var description = Console.ReadLine();

        toDoList.Add(new ToDo(toDoList.Count + 1, name, description));

    }
    else if (command[0] == "List")
    {
        ListCommand:
        Console.WriteLine("Processing command 'List'");
        if (toDoList.Count > 0)
        {

            toDoList.ForEach(toDo =>
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

       

        if (toDoList.Count > 0)
        {
            try
            {
                Console.WriteLine("Delete args: " + command[1]);
                //var filteredList = toDoList.Where(x => x.Id == Convert.ToInt32(command[1])).First();
                //Console.WriteLine();
                toDoList.RemoveAt(toDoList.IndexOf(toDoList.Where(x => x.Id == Convert.ToInt32(command[1])).First()));
                //goto ListCommand;
            }
            catch
            {
                Console.WriteLine("There is no such item");
            }
        } else
        {
            Console.WriteLine("Nothing to delete, your list is empty.");
        }

        //bool isOk = false;
        //do
        //{
        //    Console.Write("Enter item Id:");
        //    int itemId = Convert.ToInt32(Console.ReadLine);

        //    Console.WriteLine(toDoList.Where(x => x.Id == itemId).Count);

        //    //if (toDoList.Where( x =>  x.Id == itemId).Count == 1) { 

        //    //}

        //    isOk = true;
        //} while (!isOk);

    } else if (command[0] == "Update"){
        Console.WriteLine("Processing command 'Update'");
        Console.WriteLine("--------------------");
        //bool isOk = false;
        //do
        //{
        //    Console.Write("Enter item Id:");
        //    int itemId = Convert.ToInt32(Console.ReadLine);

        //    //if (toDoList.Select().Where) ;

        //    isOk = true;
        //} while (!isOk);

    } else {
        Console.WriteLine("Bye bye!");
        Environment.Exit(0);
    }

}



//public List<ToDo> getToDoList()
//{

//    return ToDoList;
//} 
