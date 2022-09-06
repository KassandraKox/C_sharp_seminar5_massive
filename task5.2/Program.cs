// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму четных элементов, стоящих на нечётных позициях
// (позиция - индекс элемента в массиве).
Random rand = new Random();
int i = 0;
int n = 6; // кол-во цифр в массиве
int [] array = new int [n]; // создан массив
int totalEven = 0; // сумма четных
while (i < n)
{
    int x = rand.Next(1, 100); //случайное число
    array[i] = x;
    if (i % 2 != 0)
    {
        if (array[i] % 2 == 0)
        {
            totalEven += array[i];
            i++;
        }
    }
    i++;
    Console.WriteLine(x);
}
Console.WriteLine(string.Join(",", array)); // вывод массива
Console.WriteLine("Сумма четных на нечетных позициях:" + totalEven); // вывод суммы четных
