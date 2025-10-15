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
    price = price - price * discount / 100;
    Console.WriteLine(name + " " + price);
}
else if ((price < 50) && (age < 18))
{
    discount = 2;
    price = price - price * discount / 100;
    Console.WriteLine(name + " " + price);
}

if ((price > 50) && (price < 100))
{
    discount = 5;
    price = price - price * discount / 100;
    Console.WriteLine(name + " " + price);
}
else if (((price > 50) && (price < 100)) && (age < 18))
{
    discount = 7;
    price = price - price * discount / 100;
    Console.WriteLine(name + " " + price);
}

if (price > 100)
{
    discount = 10;
    price = price - price * discount / 100;
    Console.WriteLine(name + " " + price);
}
else if ((price > 100) && (age < 18))
{
    discount = 12;
    price = price - price * discount / 100;
    Console.WriteLine(name + " " + price);
}