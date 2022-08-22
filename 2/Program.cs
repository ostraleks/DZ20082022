/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

Console.WriteLine($"введите размерность массива ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int odd = 0;
for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(0, 100);
    if (i % 2 == 0) odd += array[i];
   
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]\nсумма чисел на нечетных позициях - {odd}");