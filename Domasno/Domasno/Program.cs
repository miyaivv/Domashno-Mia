Console.WriteLine("Enter name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter fulll price: ");
double price = double.Parse(Console.ReadLine());

double discount = 0;

if (price < 50)
{
    discount = 0;
}
else if ((price > 50) && (price < 100))
{
    discount = 5;
}
else if (price > 100)
{
    discount = 10;
}

if (age < 18)
{
    discount += 2;
}

price = price - price * discount / 100;
Console.WriteLine(name + " " + price);