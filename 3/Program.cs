/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.WriteLine($"введите размерность массива ");
int number = Convert.ToInt32(Console.ReadLine());
double [] array = new double[number];
double max = 0;
double min = 100;
for (int i = 0; i < number; i++)
{
    array[i] = new Random().NextDouble() * 100;
    array[i] = Math.Round(array[i], 0);
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]\nразница между максимальным и минимальным элементами массива - {max - min}");