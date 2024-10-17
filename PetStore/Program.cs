using System;
using System.Diagnostics.Contracts;
using PetStore;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput.ToLower() == "1")
    {
        Product.DogLeash dogleash = new Product.DogLeash
        {
            Material = Console.ReadLine()
        };
    }
    else 
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}
 