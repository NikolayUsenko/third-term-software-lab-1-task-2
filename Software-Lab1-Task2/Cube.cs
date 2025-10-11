class Cube
{
    private double side;
    public Cube(double side) { this.side = side; }
    public double GetV() => side * side * side;
    public double GetS() => 6 * side * side;
    public void PrintInfo()
    {
        String str =
            $"           {side} \n" +
            "     +-----------+\n" +
            "    /           /|\n" +
            "   /           / |\n" +
            "  /           /  |\n" +
            " +-----------+   |\n" +
            " |           |   |\n" +
            " |           |  /\n" +
            " |           | /\n" +
            " |           |/\n" +
            " +-----------+\n";
        Console.Write("\n" + str + "\n");
        Console.WriteLine("Информация о кубе:");
        Console.WriteLine($"Сторона: {side}");
        Console.WriteLine($"Объем: {GetV()}");
        Console.WriteLine($"Площадь поверхности: {GetS()}");
    }
}