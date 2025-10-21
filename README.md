# Домашно
# Примерна домашна работа

## Задание
[Задание](https://docs.google.com/document/d/1dYI6N9vXSGMaDh6D2GC9MecRH-Q9DIPvbsoyrHAdEuY/edit?tab=t.0#heading=h.k2hmrhjqy6kz)

## Решение
[Код](http://github.com/miyaivv/Domashno-Mia/blob/main/Domasno/Domasno/Program.cs)

## Рефлексия
Условието изисква въвеждането на името и възраста на клиента заедно с пълната цена, да се изчисли отстъпка според дадени условия и в края да се върне само името и новата цена. За начало прочитаме данните от клавиатурата. Console.ReadLine() връща данни само под вид на текст, така че ползвам .Parse за да променя вида на age в int и price в double (double, а не int заради възможна полза на дроби).
 ``` c#
   ﻿Console.WriteLine("Enter name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter fulll price: ");
double price = double.Parse(Console.ReadLine());
```
След това създавам променлива discount, в която ще държа информацията за отстъпката, която за сега остава празна. 
 ``` c#
double discount = 0;
```
За отстъпка три отделни условия, които не могат да бъдат верни по едно и също време и едно (price), което може (age). 
В този случай, за да ги отделя всяко ще бъде отделен if, а всяко бонус условие else if.
В всеки if става следното:
- ще сменя големината на discount според условията
- ще сметна новата цена
- ще притира под зададения вариант
 ``` c#
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
```

че всичко да се случва в if-a.
