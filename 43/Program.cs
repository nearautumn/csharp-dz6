// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Данная программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. Значения коэффициентов должны быть целочисленными!");

int b1 = GetNumberFromUser($"Введите значение b1: ", "Ошибка ввода!");
int k1 = GetNumberFromUser($"Введите значение k1: ", "Ошибка ввода!");
int b2 = GetNumberFromUser($"Введите значение b2: ", "Ошибка ввода!");
int k2 = GetNumberFromUser($"Введите значение k2: ", "Ошибка ввода!");

FindIntersection(b1, k1, b2, k2);

///////////////////////////////////////////////////////////////////////
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

void FindIntersection(int b_1, int k_1, int b_2, int k_2) 
{
    
}