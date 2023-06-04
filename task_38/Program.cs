/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
 элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Clear();                                                      //Очищаем терминал

string RanEvNum(int num)                                              // Создаём метод принимающий целое число num
{
    double []array = new double[num];                                 //В методе объявляем массив длинной num
    for(int i = 0; i < array.Length; i++)                             // В цикле for заполняем массив вещественными числами
    {
        array[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(0, 100);
    }

    double maxNum = 0;                                               // Объявляем вещественное число maxNum
    double minNum = 99.99;                                           // Объявляем вещественное число minNum
    foreach(double el in array)                                      //В цикле foreach перебором находим максимальное и минимальное числа
    {
        maxNum = el > maxNum ? el : maxNum;
        minNum = el < minNum ? el : minNum;
    }
    return $"Разница минимального и максимального чисел массива [{String.Join(", ", array)}]\n будет {maxNum} - {minNum} = {Math.Round(maxNum - minNum, 2)}."; // Возвращаем текст с массивом и вычислением разницы максимального и минимального значения
}

Console.Write("Введите число элементов в массиве: ");               // Запрашиваем число соответствующее кол-ву элементов в массиве
int n = int.Parse(Console.ReadLine()!);                             // Вводим число соответствующее кол-ву элементов в массиве
Console.Write(RanEvNum(n));                                         // Вызывая метод RanEvNum() выводим в терминал текст
