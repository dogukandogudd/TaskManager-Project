// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

// Test Area 
TaskManager taskManager = new TaskManager(new EfTaskDal());

// WORKWORK
//DateTime start = "28.11.2021 00:00:00";
//foreach (var task in taskManager.GetByStartDate(DateTime start))
//{
//    Console.WriteLine(task.Title + " " + task.Location + " " + task.Description);
//    Console.WriteLine("--------");
//}


//GetAllByLocation Test------------------------------------------------------------
//foreach (var task in taskManager.GetAllByLocation("Eskişehir"))
//{
//    Console.WriteLine(task.Title + " " + task.Location + " " + task.Description);
//    Console.WriteLine("--------");
//}


//GetAll Test---------------------------------------------------------------------
var result = taskManager.GetAll();
if (result.Success==true)
{
    foreach (var task in taskManager.GetAll().Data)
    {
        Console.WriteLine(task.TaskTitle + " " + task.LocationId + " " + task.TaskDescription);
        Console.WriteLine("--------");
    }
}
else
{
    Console.WriteLine(result.Message);
}

