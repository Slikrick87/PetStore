using System;
using System.Diagnostics.Contracts;
using PetStore;

namespace PetStoreProgram
{

    class Program
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");
        string userInput = Console.ReadLine();

    while (userInput.ToLower() != "exit")
    {
        if (userInput.ToLower() == "1")
        {
            Dogleash dogleash = new Dogleash();
        Console.Write("Name:");
            dogleash.Name = Console.ReadLine();
            Console.Write("Price:");
            dogleash.Price = int.Parse(Console.ReadLine());
            Console.Write("Quantity");
            dogleash.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            dogleash.Quantity = Console.ReadLine();
            Console.Write("Length in inches:");
            dogleash.LengthInches = int.Parse(Console.ReadLine());
            Console.Write("Material:");
            dogleash.Material = Console.ReadLine();
            Console.WriteLine(JsonSerializer.Serialize(dogleash));
        
        }
        else if (userInput.ToLower() == "exit")
        {
            break;
        }
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");
        userInput = Console.ReadLine();
    }
}
}