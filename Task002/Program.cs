﻿// // Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6


Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine());
string Number = Convert.ToString(num);
if (Number.Length > 2)
{
  Console.WriteLine("третья цифра -> " + Number[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
