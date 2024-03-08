// Aditi Mahangade
// MIS 3013 005
// HW4 Task 2


using System.Security.Cryptography.X509Certificates;

string userChoiceStr;
string menuStr = GetMenu();
Console.WriteLine(menuStr);
string outMesStr;
do
{
    outMesStr = "\nWhat do you want to order? ";
    Console.Write(outMesStr);
    string userItemStr = Console.ReadLine();
    double price = CalculatorPrice(userItemStr);

    Console.WriteLine("\nYour Receipt");
    Console.WriteLine(userItemStr);

    ShowReceipt(price);

    Console.Write("Would you like to order anything else? (yes/no) ");
    userChoiceStr = Console.ReadLine();
}
while (userChoiceStr == "yes");
Console.WriteLine("Thank you and Goodbye!");

Console.ReadKey();
double CalculatorPrice(string itemName)
{
    if (itemName == "Fresh Coffee")
    {
        return 2.25;
    }
    else if (itemName == "Café au lait ")
    {
        return 3.72;
    }
    else if (itemName == "Latte")
    {
        return 4.03;
    }
    else if (itemName == "Hot Chocolate")
    {
        return 3.51;
    }
    else if (itemName == "Pumpkin Spice")
    {
        return 7.30;
    }
    else
    {
        return 0;
    }
}

void ShowReceipt(double price)
{
    double subtotal = price;
    string outMesStr = string.Format($"Subtotal: {price}");
    Console.WriteLine(outMesStr);

    double tax = price * 8.5 / 100; 
    outMesStr = string.Format($"Tax: {price * 8.5 / 100:C2}");
    Console.WriteLine(outMesStr);

    double total = subtotal + tax;
    outMesStr = string.Format($"Total: {total:C2}");
    Console.WriteLine(outMesStr);
}

string GetMenu()
{
    return "Cofee Shop Menu\nFresh Coffee ------ $2.25\nCafé au lait ------ $3.72\nLatte ------ $4.03\nHot Chocolate ------ $3.51\nPumpkin Spice ------ $7.30";
}
