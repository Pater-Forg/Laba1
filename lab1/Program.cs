var rand = new Random();
Console.WriteLine("Введите число:");
try
{
    var n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{n} + 32 = {n+32}");
    Console.WriteLine($"{n}^3 = {Math.Pow(n, 3)}");
    Console.WriteLine($"|{n}| = {Math.Abs(n)}");
    Console.WriteLine($"sqrt({n}) = {Math.Sqrt(n)}");

    var arr = new float[n];
    for (var i = 0; i < n; i++)
    {
        arr[i] = rand.NextSingle();
    }
    Console.WriteLine($"Случайный массив размерностью {n}:");
    foreach (var elem in arr)
    {
        Console.Write($"{elem} ");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

