// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int m = GetNumberFromUser("Введите количество чисел M: ", "Ошибка ввода!");
int[] array = new int[m];
for (int index = 0; index < m; index++) 
{
    array[index] = GetNumberFromUser($"Введите эемент массива {index}: ", "Ошибка ввода!");
}
PositivesCount(array);

//////////////////////////////////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage) 
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect) return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void PositivesCount(int[] numbers) 
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++) 
    {
        if (numbers[i] > 0) result++;
    }
    Console.WriteLine($"{String.Join(" ", numbers)} -> {result}");
}