//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size, int minRange, int maxRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void ShowReverseArray(int[] arr, int j)
{
    if (j < 0)
    {
        return;
    }
    
    Console.Write($"{arr[j]} ");
    ShowReverseArray(arr, j - 1);
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N, 1, 100);

Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
ShowReverseArray(res, res.Length - 1);
Console.WriteLine();

