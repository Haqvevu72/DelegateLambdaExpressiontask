using System.Reflection.Metadata.Ecma335;

class Calcuator {
    // Calculations
    private Func<int> Sum = () =>
    {
        int num1 = 0, num2 = 0;
        Console.Write("Num1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Num1: ");
        num2 = int.Parse(Console.ReadLine());
        return num1 + num2;
    };
    private Func<int> Subtract = () =>
    {
        int num1 = 0, num2 = 0;
        Console.Write("Num1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Num1: ");
        num2 = int.Parse(Console.ReadLine());
        return num1 - num2;
    };
    private Func<int> Multiply = () =>
    {
        int num1 = 0, num2 = 0;
        Console.Write("Num1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Num1: ");
        num2 = int.Parse(Console.ReadLine());
        return num1 * num2;
    };
    private Func<float> Divide = () =>
    {
        float num1 = 0, num2 = 0;
        Console.Write("Num1: ");
        num1 = float.Parse(Console.ReadLine());
        Console.Write("Num2: ");
        num2 = float.Parse(Console.ReadLine());
        return num1 / num2;
    };
    private Func<int> Square = () =>
    {
        int num1 = 0;
        Console.Write("Num1: ");
        num1 = int.Parse(Console.ReadLine());
        return num1 * num1;
    };
    private Func<int> Factorial = () =>
    {
        int num = 0;
        Console.Write("Num: ");
        num = int.Parse(Console.ReadLine());
        int factorial = 1;
        while (num > 0)
        {
            factorial *= num;
            num -= 1;
        }
        return factorial;
    };

    // Calculator
    public void calculator(){
        ConsoleKeyInfo key;
        int? num1 = 0 ,num2 = 0;
        while (true) {
            Console.Clear();
            Console.WriteLine("[1] Sum (+)");
            Console.WriteLine("[2] Subtract (-)");
            Console.WriteLine("[3] Multiply (*)");
            Console.WriteLine("[4] Divide");
            Console.WriteLine("[5] Square");
            Console.WriteLine("[6] Factorial");
            Console.Write("Choice: ");
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1) {
                Console.Clear();
                Console.WriteLine($"Result:{Sum()}");
                break;
            }
            else if (key.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine($"Result:{Subtract()}");
                break;
            }
            else if (key.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine($"Result:{Multiply()}");
                break;
            }
            else if (key.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Console.WriteLine($"Result:{Divide()}");
                break;
            }
            else if (key.Key == ConsoleKey.D5)
            {
                Console.Clear();
                Console.WriteLine($"Result:{Square()}");
                break;
            }
            else if (key.Key == ConsoleKey.D6)
            {
                Console.Clear();
                Console.WriteLine($"Result:{Factorial()}");
                break;
            }
        }
    }
}
