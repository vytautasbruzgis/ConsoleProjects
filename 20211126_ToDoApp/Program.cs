// See https://aka.ms/new-console-template for more information
using _20211126_ToDoApp.Models;
using System.Linq;

Console.WriteLine("Welcome to your toDoList app!");

List<Book> bookList = new List<Book>();
//toDoList = getToDoList();

while (true)
{
    /* sukam programą */
    Console.WriteLine("Choose your command: 'Add', 'List', 'Delete +name', 'Update'");
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
        //Console.Write("Enter description:");
        var description = readDescription(false);
        //Console.Write("Enter amount:");
        var amount = readAmount();//Convert.ToInt32(Console.ReadLine());
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
        
        

        //var name = Console.ReadLine();
        bool repeat = true;

        while (repeat)
        {
            Console.Write("Enter bookname to update or type 'exit' to exit update:");
            var name = Console.ReadLine();
            
            if (name != "exit") {

                try
                {
                    int itemNo = 0;
                    itemNo = bookList.IndexOf(bookList.Where(x => x.Title == name).First());

                    //Console.Write("Enter description:");
                    var description = readDescription(false);
                    //Console.Write("Enter amount:");

                    var amount = readAmount(); //Convert.ToInt32(Console.ReadLine());
                    bookList[itemNo].updateBook(name, description, amount);
                    
                    repeat = false;

                } catch
                {
                    Console.WriteLine("There is no such book to update.");
                }
            
                
            }


        }


    } else {
        Console.WriteLine("Bye bye!");
        Environment.Exit(0);
    }


    int readInt()
    {
        bool repeat = true;
        int result = 0;
        while (repeat)
        {   
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
                repeat = false;

            } catch
            {
                Console.Write("You've entered non numeric value. Please enter again: ");
            }
            
        }
        return result;
    }

    int readAmount()
    {
        Console.Write("Enter amount:");
        return readInt();
    }

    string readDescription(bool canBeEmpty)
    {
        bool repeat = true;
        string result = "";

        while (repeat)
        {
            Console.Write("Enter description:");
            result = Console.ReadLine();
            if (result == "") 
            {
                if (canBeEmpty == false)
                {
                    Console.WriteLine("Value cannot be empty:");
                } else
                {
                    repeat = false;
                }
            }
            else
            {
                repeat = false;
            }
        }
        return result;
    }

}



//public List<ToDo> getToDoList()
//{

//    return ToDoList;
//} 
