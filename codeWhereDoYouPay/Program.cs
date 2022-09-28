// Алгоритм
// 1. Ввести число
// 2. Найти его в массиве
// 3. Вернуть количество таких чисел в массиве

Console.Write("Введите число:");
int WhereDoYouPay = Convert.ToInt32(Console.ReadLine()); // Ввод данных из терминала с помощью конвертера из string в int
int [] arr = new int [5]; // Массив из 5 элементов
arr [0] = 3;
arr [1] = 3;
arr [2] = 4;
arr [3] = 3;
arr [4] = 2;
//Console.WriteLine($"arr: {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}"); // Вывод на экран элементов массива
//int n = 0; // Счетчик индексов массива
int count = 0; // Счетчик количества искомых чисел
//while (n<5)
for(int n = 0; n < arr.Length; n++)
{
    if (WhereDoYouPay == arr[n]);
    {
        count++;
    }
//n=n+1;
}
Console.WriteLine(count);
//Console.WriteLine(n); // почему-то не возвращает n?