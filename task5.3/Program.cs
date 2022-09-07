// Задать массив нат. чисел. Найти разницу между макс и мин элементов массива.
Random rand = new Random();
int i = 0;
int n = 4; // кол-во цифр в массиве
int [] array = new int [n]; // создан массив
int minx = 100;  // объявление минимального
int maxx = 0;  // объявление максимального

while (i < n)
{
    int x = rand.Next(1, 100); //случайное число
        array[i] = x;
        //Console.WriteLine(x);
        
    if (array[i] >= maxx)
    {
        maxx = array[i];
        //Console.WriteLine("Max " + maxx);
    }
    if (array[i] <= minx)
    {
        minx = array[i];
        //Console.WriteLine("Min " + minx);
    }
    i++;
}

int result = maxx - minx;
Console.WriteLine(string.Join(",", array)); // вывод массива
Console.WriteLine("Max " + maxx);
Console.WriteLine("Min " + minx);
Console.WriteLine("Разница между макс и мин равна:" + result); // вывод разницы

