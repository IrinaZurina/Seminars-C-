Console.Clear();
int quarter;

try
{
    Console.Write("Введите номер четверти: ");
    quarter = int.Parse(Console.ReadLine() ?? "");
}

catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода даных! {exc.Message}");
    return;
}

string answer = PrintCoordsByQuarter(quarter);

static string PrintCoordsByQuarter(int quarter)
{
    string answer;
    if (quarter == 1) answer = "x > 0, y > 0";
    else if (quarter == 2) answer = "x < 0, y > 0";
    else if (quarter == 3) answer = "x < 0, y < 0";
    else if (quarter == 4) answer = "x > 0, y < 0";
    else answer = "Ошибка! Четверть введена неправильно";
    Console.WriteLine(answer);
    return answer;
}