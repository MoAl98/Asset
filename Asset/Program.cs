using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections;
using Asset;
using System;
//Mohammad Al-Aarag
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello User!");
Console.ResetColor();
List<Device> devices = new List<Device>();//create an object

while (true)
{
   
    try
    {
        //input value from user to the list
        Console.Write("Enter a new device type (Phone or computer): ");
        string TypeOfDevice = Console.ReadLine();

        Console.Write("Enter the brand name: ");
        string brand = Console.ReadLine();

        Console.Write("Enter the model: ");
        string model = Console.ReadLine();

        Console.Write("Enter the office name: ");
        string office = Console.ReadLine();

        Console.Write("Enter the purchase date: ");
        string date = Console.ReadLine();
        DateTime purchaseDate = Convert.ToDateTime(date);
           
        Console.Write("Enter the price in USD: ");
        int Price;
        while (!int.TryParse(Console.ReadLine(), out Price)) // read the price and make sure the input is a number     
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please enter a number ");
            Console.ResetColor();

        }
        Console.Write("Enter the currency: ");
        string currency = Console.ReadLine();

        Console.Write("Enter the local price today: ");
        int lokalPris;
        while (!int.TryParse(Console.ReadLine(), out lokalPris)) // read the local price and make sure the input is a number     
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please enter a number ");
            Console.ResetColor();

        }

       devices.Add(new Device(TypeOfDevice, brand, model, office, purchaseDate, Price, currency, lokalPris));
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Please enter a valid value " + e);
        Console.ResetColor();
        

    }


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The product was succesfully added ");
    Console.ResetColor();
    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");


    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("If you want to start the program again press: p --------Otherwise press anything to end the program");
    Console.ResetColor();

    string igen = Console.ReadLine();

    if (igen.ToLower().Trim() != "p")//check if the user want to put more values and start the program again if the user want to
    {
        break;
        
    }


}

Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Type".PadRight(10) + "Brand".PadRight(10) + "Model".PadRight(10) + "Office".PadRight(10) + "Purchase Date".PadRight(20) + "Price in USD".PadRight(15) + "Currency".PadRight(10) + "Local price today");
Console.ResetColor();
List<Device> sortedPrice = devices.OrderBy(Device => Device.Office).ThenBy(Device => Device.PurchaseDate).ToList(); //sort the list


foreach (Device device in sortedPrice)
{

    if (device.PurchaseDate > DateTime.Now.AddMonths(-3)  && device.PurchaseDate > DateTime.Now.AddMonths(-36))//check if the purchase date is less than 3 months and less than 3 years
    {
        Console.ForegroundColor = ConsoleColor.Red;//print red if this conndition is true
        Console.WriteLine(device.Print());//call the method print from Produkten class


    }
    else if (device.PurchaseDate < DateTime.Now.AddMonths(-3) &&device.PurchaseDate > DateTime.Now.AddMonths(-6) && device.PurchaseDate > DateTime.Now.AddMonths(-36))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(device.Print());

    }
    else
    {
        Console.WriteLine(device.Print());

    }
    Console.ResetColor();
}




//class Computers : Device
//{
//    public Computers(string Brand, string Model, string Office, DateTime PurchaseDate, int Price, string Currency, int LokalPris) : base(Brand, Model, Office, PurchaseDate, Price, Currency, LokalPris)
//    {

//    }

//}

//class Phones : Device
//{
//    public Phones(string Brand, string Model, string Office, DateTime PurchaseDate, int Price, string Currency, int LokalPris) : base(Brand, Model, Office, PurchaseDate, Price, Currency, LokalPris)
//    {

//    }


//}
