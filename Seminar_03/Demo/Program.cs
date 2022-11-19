// Начало программы
Console.Clear();
int X = 0, Y = 0;   //инициализируем переменные
InitCoordinatesByUser(ref X, ref Y);   // Вызов метода с передачей параметров по ссылке ref
PrintQuarterByCoords(X, Y);   // Вызов метод с передачей параметров по значению
// Конец программы

// Определям метод для ввода значений координат
static void InitCoordinatesByUser(ref int X, ref int Y)
{
    try
    {
        Console.Write("Введите X: ");
        X = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y: ");
        Y = int.Parse(Console.ReadLine() ?? "");
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода даных! {exc.Message}");
        return;
    }
}

// Вводми метод для определения номера четверти
static void PrintQuarterByCoords(int X, int Y)
{
    if(X > 0 && Y > 0) Console.WriteLine("1");

    else if(X < 0 && Y > 0) Console.WriteLine("2");

    else if(X < 0 && Y < 0) Console.WriteLine("3");

    else if(X > 0 && Y < 0) Console.WriteLine("4");

    else Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}