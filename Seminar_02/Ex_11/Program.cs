int num_random = new Random().Next(100, 1000);
Console. WriteLine($"{num_random} -> ");

int last_digit = num_random % 10;
int first_digit = num_random / 100;

int new_number = first_digit * 10 + last_digit;

Console.WriteLine($"{num_random} -> {new_number}");
