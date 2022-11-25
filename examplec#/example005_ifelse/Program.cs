Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ната")
{
    Console.WriteLine("Ура, это же НАТА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}