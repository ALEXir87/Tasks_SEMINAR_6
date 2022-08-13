// Задача №41:Пользователь вводит с клавиатуры M чисел в одну линию(не используем Enter). 
// Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Задача №41");
Console.Write("Введи числа через пробел: ");
int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();
int count = 0; 
for (int i = 0; i < numbers.Length; i++){
    if (numbers[i] > 0){
        count++;}}
Console.WriteLine($"Количество чисел больше 0 = {count}");