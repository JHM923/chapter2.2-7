using System;
using System.Collections.Generic;

namespace chapter2._2_7
{
    class Program
    {
        static void PrintType<T>()
        {
            Console.WriteLine("typef(T) = {0}", typeof(T));
            Console.WriteLine("typef(List<T>) = {0}", typeof(List<T>));
        }
        static void Main()
        {
            PrintType<string>(); //使用string作为类型实参调用方法
            PrintType<int>();    //使用int作为类型实参调用方法
            Console.ReadKey();
        }
    }
}
