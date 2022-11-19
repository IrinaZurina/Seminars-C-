// Программа принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

// ------- Основной блок кода - начало -------
Console.Clear();

// Вводим координаты первой точки
int X1 = UserInput("Введите координату X1: ");
int Y1 = UserInput("Введите координату Y1: ");
int Z1 = UserInput("Введите координату Z1: ");

// Вводим координаты второй точки
int X2 = UserInput("Введите координату X2: ");
int Y2 = UserInput("Введите координату Y2: ");
int Z2 = UserInput("Введите координату Z2: ");


double answer = DistanceIn3D (X1, Y1, Z1, X2, Y2, Z2);   // вызываем метод
Console.WriteLine($"{answer}");   // выводим ответ
// ------- Основной блок кода - конец -------

// Метод для ввода данных
static int UserInput (string message)
{
    try
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine() ?? ""); 
    }

    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода даных! {exc.Message}");
        return 0;
    }
}

// Метод для расчета расстояния
static double DistanceIn3D (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
}
