// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowNambers (int M, int N) 
{
    if (M <= 0)
    {
        Console.WriteLine("Ошибка: M должно быть больше 0.");
        return;
    }

    if (N <= 0)
    {
        Console.WriteLine("Ошибка: N должно быть больше 0.");
        return;
    }

    if (M > N)
    {
        Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
        return;
    }

    if (M < N)  
    {
        Console.Write(M + " ");  
        ShowNambers(M + 1, N); 
        return;
    }
}

Console.Write("Введите число M: "); 
int M = Convert.ToInt32(Console.ReadLine());  
Console.Write("Введите число N: ");  
int N = Convert.ToInt32(Console.ReadLine());  


ShowNambers(M, N);  
