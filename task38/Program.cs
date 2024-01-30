// Переписать все положительные элементы матрицы С(6,8) в вектор А. используя метод простой сортировки, расположить их по возрастанию.

Random rand = new Random();
List<int> A = new List<int>();
int[,] ptrC = new int[6, 8];

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 8; j++)
    {
        ptrC[i, j] = rand.Next(100) - rand.Next(100);
        Console.Write(ptrC[i, j] + " ");
        if (ptrC[i, j] > 0)
        {
            A.Add(ptrC[i, j]);
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Положительные элементы: ");
foreach (var item in A)
{
    Console.Write(item + " ");
}
Console.WriteLine();

A.Sort();
Console.WriteLine("Отсортированные положительные элементы: ");
foreach (var item in A)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.ReadKey();

