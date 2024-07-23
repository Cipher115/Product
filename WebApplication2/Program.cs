using WebApplication2.Models;
using WebApplication2.Helpers;
using WebApplication2.Exceptions;
using WebApplication2.Services;

try
{
    //Ask the user ti input their id and price
    Console.WriteLine("Please input your id:");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Please input the price of your order:");
    int num2 = int.Parse(Console.ReadLine());


   
}
//Exception to make sure id and price are not negative
catch (NegativeNumberException ex)
{
   
    Console.WriteLine("Price amount or id can not be 0: " + ex.Message);
}

finally
{
    // Code Executes
    Console.WriteLine("Execution was successful.");
}



var contactManager = new ProductManager();
try
{
    contactManager.AddContact(new Product { Id = 1, Name = "apple", Description = "fruit", Price = 2.72m, StockAmount = 350 });
    contactManager.AddContact(new Product { Id = 1, Name = "banana", Description = "fruit", Price = 1.7m, StockAmount = 252 });
}
//to invalidate duplicate id
catch (DuplicateIdException ex)
{
    Console.WriteLine(ex.Message);
}
//An error outside of the ordinary occured
catch (Exception ex)
{
    Console.WriteLine($"An unkown error has occurred: {ex.Message}");
}

