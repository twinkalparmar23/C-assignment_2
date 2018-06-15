using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatSum
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = 0.06f, Y = 5.94f,ans=0.0f;

            Console.WriteLine("X : " + X);
            Console.WriteLine("Y : " + Y);
            ans = X + Y;

            Console.WriteLine("\n sum of X and Y is:"+ans);

            bool compareOp = ((X + Y) == ans);
            Console.WriteLine("\n X+Y == ans :" + compareOp);

            bool compareEqual = X.Equals(Y);
            Console.WriteLine("X+Y equals sum:" + compareEqual);

            Max(X, Y);

        }

        static void Max<T>(T x,T y) where T:IComparable<T>
        {
            if ((x.CompareTo(y) > 0))
                Console.WriteLine("\nX is greater");
            if ((y.CompareTo(x)) > 0)
                Console.WriteLine("\nY is greater");


            //int result = x.CompareTo(y);
            //if (result == 0)
            //    Console.WriteLine("{0} == {1}", x, y);
            //else if(result>0)
            //    Console.WriteLine("{0} > {1}", x, y);
            //else
            //    Console.WriteLine("{0} < {1}", x, y);
        }
    }
}
