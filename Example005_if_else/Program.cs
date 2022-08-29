// Программа приветсвия. User вводит свое имя и программа 
//здоровается, в ответ фраза: Ура это же Маша.
Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else


{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
