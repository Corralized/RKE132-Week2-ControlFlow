// See https://aka.ms/new-console-template for more information
//vanuse sisestamine ja kontroll, kui oled noorem kui .., muul juhul kuvatakse tervist

Console.WriteLine("Enter your age:");


int userAge = Int32.Parse(Console.ReadLine());



if(userAge >= 13)
{
    Console.WriteLine("Welcome to Tallinn!");
}
else
{
    Console.WriteLine("You are too young to visit Tallinn");
}