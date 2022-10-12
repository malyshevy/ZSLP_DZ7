// Задача 50. Напишите программу, которая 
//на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента 
//или же указание, что такого элемента нет.

Console.Clear();
double[,] numersArray = EnterNumersRandom();
int[] sequenceNumberArray = UserEnterNumers();
Console.WriteLine("Все элементы массива с их порядковыми номерами : ");
OutputArray(numersArray);
Console.WriteLine();
ResultOutput(numersArray, sequenceNumberArray);

double[,] EnterNumersRandom()
{
    int siseString = new Random().Next(1, 21);
    int siseColumn = new Random().Next(1, 21);
    Console.WriteLine($"Массив состоит из {siseString} строк и {siseColumn} столбцов, подсчёт начинается с 0 позиции");
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

int[] UserEnterNumers()
{
    Console.Write("Введите номер строки массива ");
    int siseString = int.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца массива ");
    int siseColumn = int.Parse(Console.ReadLine());
    int[] userEnterNumersArr = new int [2];
    userEnterNumersArr[1] = siseColumn;
    userEnterNumersArr[0] = siseString;
    Console.WriteLine();
    return (userEnterNumersArr);
}

void OutputArray(double[,] numerArray)
{
    Console.WriteLine();
    for (int i = 0; i <= numerArray.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= numerArray.GetUpperBound(1); j++)
        {
            Console.Write($"({numerArray[i, j]} ({i}|{j})), ");
        }
        Console.WriteLine();
    }
}

void ResultOutput(double[,] numerArray, int[] sequenceNumberArr)
{
    if ((sequenceNumberArr[0] > numerArray.GetUpperBound(0)) || (sequenceNumberArr[1] > numerArray.GetUpperBound(1)))
    {
        Console.WriteLine($"Массив не содержит позицию под номером ({sequenceNumberArr[0]}|{sequenceNumberArr[1]})");
    }
    else
    {
        Console.WriteLine($"Позиция под номером ({sequenceNumberArr[0]}|{sequenceNumberArr[1]} = {numerArray[sequenceNumberArr[0], sequenceNumberArr[1]]})");
    }
}



