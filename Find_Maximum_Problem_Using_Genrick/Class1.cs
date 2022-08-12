using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Maximum_Problem_Using_Genrick
{
    class Maximum_Number
    {
        public void Find_Max_Num(int First, int Secound, int Third)
        {
            if (First.CompareTo(Secound) > 0 && First.CompareTo(Third) > 0 || First.CompareTo(Secound) >= 0 && First.CompareTo(Third) > 0 || First.CompareTo(Secound) > 0 && First.CompareTo(Third) >= 0)
            {
                Console.WriteLine(First + " is greter than " + Secound + " " + Third);
            }
            else if (Secound.CompareTo(First) > 0 && Secound.CompareTo(Third) > 0 || Secound.CompareTo(First) >= 0 && Secound.CompareTo(Third) > 0 || Secound.CompareTo(First) > 0 && Secound.CompareTo(Third) >= 0)
            {
                Console.WriteLine(Secound + " is greter than " + First + " " + Third);
            }
            else if (Third.CompareTo(First) > 0 && Third.CompareTo(Secound) > 0 || Third.CompareTo(Secound) >= 0 && Third.CompareTo(First) > 0 || Third.CompareTo(Secound) > 0 && Third.CompareTo(Secound) >= 0)
            {
                Console.WriteLine(Third + " is greter than " + Secound + " " + First);
            }
            Console.ReadKey();
        }
    }
}
