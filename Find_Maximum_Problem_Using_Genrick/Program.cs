﻿using System;

namespace Find_Maximum_Problem_Using_Genrick
{
    

    
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 112, 334, 432, 555, 678, 800 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();
        }
    }
}
 