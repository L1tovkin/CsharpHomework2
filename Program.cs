/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
Console.WriteLine("Введите трехзначное число: ");
int number = new Random().Next(1, 1000);
Console.WriteLine(number);
Console.WriteLine((number % 100) / 10);
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.WriteLine("Заданное число a: ");
int a = int.Parse(Console.ReadLine());
int target = 0;

while (a / 100 != 0){
    if (a >= 1000){
        a = a / 10;
        Console.WriteLine(a);
    }
    if (a < 1000){
        target = a % 10;
        Console.WriteLine($"Третье число {target}");
        break;
    }
}
if (a / 100 == 0){
    Console.WriteLine("Третьего числа нет");
}
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*
Console.WriteLine("Введите число, обознач. день недели: ");
int n = int.Parse(Console.ReadLine());
if (n < 6){
    Console.WriteLine("нет");
}
else {
    Console.WriteLine("да");
}
*/