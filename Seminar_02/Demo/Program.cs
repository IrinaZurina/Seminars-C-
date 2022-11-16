int num_random = new Random().Next(10, 100);
Console. WriteLine($"{num_random} -> ");

int second_digit = num_random % 10;
int first_digit = num_random / 10;

int max;

if (first_digit > second_digit) max = first_digit;

else max = second_digit;

Console.WriteLine($"{num_random} -> {max}");
