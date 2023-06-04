﻿/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();                                                      //Очищаем терминал

string RanEvNum(int num)                                              // Создаём метод принимающий целое число num
{
    int []array = new int[num];                                       //В методе объявляем массив длинной num
    for(int i = 0; i < array.Length; i++)                             // В цикле for заполняем массив целыми трёхзначными числами
    {
        array[i] = new Random().Next(100, 1000);
    }

    int count = 0;                                                   // Объявляем целое число count для записи кол-ва чётных чисел в массиве
    foreach(int el in array)                                         //В цикле foreach перебором находим чётные числа и записываем их кол-во в count
    {
        count += el % 2 == 0 ? 1 : 0;
    }
    
    return $"В массиве [{String.Join(", ", array)}] {count} чётных чисел.";  // Возвращаем текст с массивом и кол-вом чисел стоящих на чётных позициях
}

Console.Write("Введите число элементов в массиве: ");               // Запрашиваем число соответствующее кол-ву элементов в массиве
int n = int.Parse(Console.ReadLine()!);                             // Вводим число соответствующее кол-ву элементов в массиве
Console.Write(RanEvNum(n));                                         // Вызывая метод RanEvNum() выводим в терминал текст
