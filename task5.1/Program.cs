// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Random rand = new Random();
int i = 0;
int n = 4; // кол-во цифр в массиве
int [] array = new int [n];
int count = 0;
while (i < n)
{
    int x = rand.Next(100, 1000); //случайное число
    array[i] = x;
    if (array[i] % 2 == 0)
    {
        count++;
    }
    i++;
}
Console.WriteLine(string.Join(",", array)); // вывод массива
Console.WriteLine("Из них четных:" + count); // вывод счетчтка четных
