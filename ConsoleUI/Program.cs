// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

// Test Area 
TaskManager taskManager = new TaskManager(new EfTaskDal());

//GetAll Test
var result = taskManager.GetAll();
if (result.Success==true)
{
    foreach (var task in taskManager.GetAll().Data)
    {
        Console.WriteLine("#"+task.TaskTitle + "(" + task.LocationId + ") " );
        Console.WriteLine("#" + task.TaskDescription);
        Console.WriteLine(" ");
    }
}
else
{
    Console.WriteLine(result.Message);
}

