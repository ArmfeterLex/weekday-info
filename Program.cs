string mes;
Console.WriteLine("Введите номер дня недели: 1, 2, 3, 4, 5 ,6 ,7");
string day = Console.ReadLine();
switch (day)
    {case "1": mes = "Понедельник"; break;
     case "2": mes = "Вторник"; break;
     case "3": mes = "Среда"; break;
     case "4": mes = "Четверг"; break;
     case "5": mes = "Пятница"; break;
     case "6": mes = "Суббота"; break;
     case "7": mes = "Воскресенье"; break;
    default: mes = "Некорректный номер дня недели"; break;
    }
Console.WriteLine(mes);
if (mes == "Суббота" || mes == "Воскресенье")
{
    Console.WriteLine("Выходной");
}
else if (mes != "Некорректный номер дня недели")
{
    Console.WriteLine("Рабочий день");
    Console.ReadKey();
}
