using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Problem_Using_Genrick
{
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
