//Задача 52. 
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int[,] numersArray = UserEnterNumersConsol();
ResultOutputConsol(numersArray);
ResultOutput(numersArray);

int[,] UserEnterNumersConsol()
{
    Console.Write("Введите количество строк массива ");
    int siseString = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива ");
    int siseColumn = int.Parse(Console.ReadLine());
    int[,] enterNumersArray = new int[siseString, siseColumn];
    for (int i = 0; i < siseString; i++)
    {
        for (int j = 0; j < siseColumn; j++)
        {
            enterNumersArray[i, j] = new Random().Next(-99, 100);
        }
    }
    return (enterNumersArray);
}

void ResultOutputConsol(int[,] numerArray)
{
    Console.WriteLine();
    for (int i = 0; i <= numerArray.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            Console.Write($"{numerArray[i, j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void ResultOutput(int[,] numerArray)
{
    for (int i = 0, k = 1; i <= numerArray.GetUpperBound(0); i++, k++)
    {
        double sum = 0;
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            sum = sum + numerArray[i, j];
        }
        Console.WriteLine($"Среднее арифметическое строки {k} = {Math.Round(sum / numerArray.GetLength(1), 3)}");
    }
}

