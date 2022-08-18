Console.Write("Привет, как тебя зовут? ");
string username = Console.ReadLine();

if(username.ToLower() == "михаил")
{
    Console.WriteLine("Слава белому господину!!!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}