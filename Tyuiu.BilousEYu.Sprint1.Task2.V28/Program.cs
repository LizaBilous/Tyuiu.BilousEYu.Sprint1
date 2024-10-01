using Tyuiu.BilousEYu.Sprint1.Task2.V28.Lib;


Console.Title = "Спринт #1 | Выполнил: Билоус Е. Ю. | ИСТНб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Билоус Елизавета Юрьевна | ИСТНб-24-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


DataService ds = new DataService();
Console.WriteLine("Введите значение x:");
var x = Convert.ToInt32(Console.ReadLine());
var result = ds.ConvertCelsiusToKelvin(x);
Console.WriteLine(result);
Console.ReadLine();
Console.ReadKey();

