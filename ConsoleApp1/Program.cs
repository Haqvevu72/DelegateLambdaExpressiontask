class Program
{
    static Predicate<int> IsPositive = num =>{if (num > 0) { return true; }
        else { return false; }
    };
    static Action<int> SquareAct = num => Console.WriteLine(num*num);
    static Func<int, int> SquareFunc = num => num * num;

    static void Main(string[] args)
    {
        Calcuator calcuator = new Calcuator();
        calcuator.calculator();
    }
}