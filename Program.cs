using LAB05;

// 1. Создание объектов и чтение свойств
CustomTime t1 = new CustomTime(14, 5);
Console.WriteLine($"t1: Hour = {t1.Hour}, Minutes = {t1.Minutes}");
t1.PrintTime();

// 2. Изменение свойств
t1.Hour = 9;
t1.Minutes = 30;
t1.PrintTime();

// 3. AddMinutes
t1.AddMinutes(45);          // 10:15
t1.PrintTime();

CustomTime t2 = new CustomTime(23, 50);
t2.AddMinutes(20);          // переход через 00:00 -> 00:10
t2.PrintTime();

CustomTime t3 = new CustomTime(10, 0);
t3.AddMinutes(1500);        // 25 часов -> 11:00
t3.PrintTime();

// 4. Валидация и обработка исключений
try
{
    CustomTime bad = new CustomTime(24, 0);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

try
{
    t1.Minutes = 60;
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

try
{
    t1.Hour = -1;
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}