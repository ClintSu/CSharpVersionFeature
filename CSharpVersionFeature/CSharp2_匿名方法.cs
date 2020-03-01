/*
 * C#2.0 匿名方法
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVersionFeature
{
    public class CSharp2_匿名方法
    {
        //匿名方法,无方法名
        static Func<int, int, int> sum = delegate(int a, int b) { return a + b; };
        public static void Test()
        {
            var result = sum(15, 4);
            Console.WriteLine(result);
        }
    }
}
