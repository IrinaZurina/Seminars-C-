// 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Clear();

int numDec = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");

int numBin = ConvertDecimalToBinary(numDec);

Console.Write($"{numDec} -> {numBin}");

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

int ConvertDecimalToBinary(int num)
{
    int result = 0;
    int i = 0;
    while (num > 0)
    {
        result += num % 2 * (int)Math.Pow(10, i);
        num /= 2;
        i ++;
    }
    return result;
}