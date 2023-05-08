Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoise = Console.ReadLine();

if (userChoise == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}




static void PrintHello() //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See your later!");
}
