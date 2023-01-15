// Написать приложение, которое будет разных пользователей приветствовать по-разному,
// а именно: выделим для себя условного любимчика, и наше приложение будет
// реагировать на него по-особенному.

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
