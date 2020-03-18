using System;

namespace _09ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Aver myDelegat = new Aver(delegate (int a, int b, int c) { Console.WriteLine((a + b + c) / 3); });
            int x = 5;
            int y = 5;
            int z = 5;
            myDelegat.Invoke(x, y, z);
        }
    }
    public delegate void Aver(int a, int b, int c);
}
