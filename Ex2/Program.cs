using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = (a, b) => a + b;
            Sub sub = (a, b) => a - b;
            Mul mul = (a, b) => a * b;
            Div div = (a,b) => { if (b != 0) return a / b; else { Console.WriteLine("Не ну как так? Сейчас мы тебя на ноль поделим. Приятно будет?"); return 0; } };
            int x = 5;
            int y = 5;
            Console.WriteLine(div.Invoke(x, y));
            Console.WriteLine(sum(x, y));
            Console.WriteLine("Hello World!");
        }
    }
    public delegate int Sum(int a, int b);
    public delegate int Sub(int a, int b);
    public delegate int Mul(int a, int b);
    public delegate int Div(int a, int b);
}
