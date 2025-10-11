class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину стороны куба: ");
        double side = Convert.ToDouble(Console.ReadLine());
        while (side <= 0)
        {
            Console.Write("\nСторона куба должна быть положительной. Попробуйте снова: ");
            side = Convert.ToDouble(Console.ReadLine());
        }
        Cube cube = new(side);
#if DEBUG
        Console.WriteLine($"\n[DEBUG] Создан объект класса Cube со стороной side = {side}");
#else
        cube.PrintInfo();
#endif
#if DEBUG
        Console.WriteLine("\nПрограмма завершена (режим DEBUG).");
#else
        Console.WriteLine("\nПрограмма завершена (режим RELEASE).");
#endif
    }
}