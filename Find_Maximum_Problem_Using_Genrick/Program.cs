using System;

namespace Find_Maximum_Problem_Using_Genrick
{
    class Generic<T>
    {
        public Generic(T msg)
        {
            Console.WriteLine(msg);
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<string> gen = new Generic<string>("This is generic class");
            Generic<int> genI = new Generic<int>(101);
            Generic<char> getCh = new Generic<char>('I');
        }
    }
}
 