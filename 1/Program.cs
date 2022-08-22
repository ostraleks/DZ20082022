/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.WriteLine($"введите размерность массива ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int even = 0;
for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) even ++;
   
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]\nчетных чисел - {even}");
