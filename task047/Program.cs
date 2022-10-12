// Задача 47. Задайте двумерный массив 
//размером m×n, 
//заполненный случайными вещественными числами.

Console.Clear();
double[,] numersArray = UserEnterNumersConsol();
ResultOutput(numersArray);

double[,] UserEnterNumersConsol()
{
    Console.Write("Введите количество строк массива ");
    int siseString = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива ");
    int siseColumn = int.Parse(Console.ReadLine());
    double[,] enterNumersArray = new double[siseString, siseColumn];
    for (int i = 0; i < siseString; i++)
    {
        for (int j = 0; j < siseColumn; j++)
        {
            enterNumersArray[i, j] = Convert.ToDouble(new Random().Next(-1000, 1001)) / 10;
        }
    }
    return (enterNumersArray);
}

void ResultOutput(double[,] numerArray)
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
}
