// 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// Запрашиваем у пользователя число, которое будем искать
Console.Clear();
int userNum = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");

// Создаем и заполняем массив
int[] array = GetArray(12, -9, 9);

// Создаем переменную, в которую будет записан ответ
string answer = IsThereANumber(array, userNum);
Console.Write(String.Join(" ", array));
Console.WriteLine($" -> {answer}");


// Метод для получения числа от пользователя
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

// Метод для генерации исходного массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// метод для поиска в массиве числа, введенного пользователем
// !! Можно реализовать через bool, а не string
string IsThereANumber(int[] array, int num)
{
    string answer = "";
    foreach (int element in array)
    {
        if (element == num) 
        {
            answer = "да";
            break;
        }
        else answer = "нет";
    }

    return answer;
    
}