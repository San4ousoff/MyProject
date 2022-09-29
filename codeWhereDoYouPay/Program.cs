// Алгоритм
// 1. Ввести число
// 2. Найти его в массиве -> Найти его в рандомном массиве
// 3. Вернуть количество таких чисел в массиве

Console.Write("Введите число от 0 до 10: ");
int WhereDoYouPay = Convert.ToInt32(Console.ReadLine()); // Ввод данных из терминала с помощью конвертера из string в int
int [] arr = new int [5]; // Массив из 5 элементов
arr [0] = new Random().Next(0,11);
arr [1] = new Random().Next(0,11);
arr [2] = new Random().Next(0,11);
arr [3] = new Random().Next(0,11);
arr [4] = new Random().Next(0,11);
Console.WriteLine($"Массив: {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}"); // Вывод на экран элементов массива
int n = 0; // Счетчик индексов массива
int count = 0; // Счетчик количества искомых чисел
while (n < arr.Length) // Количество элементов в массиве [5]
//for(int n = 0; n < arr.Length; n++)
{
    if (WhereDoYouPay == arr[n])
    {
        count++;
    }
n++;
// Console.WriteLine(n);
}
Console.WriteLine($"Выбранных чисел в массиве: {count}");
