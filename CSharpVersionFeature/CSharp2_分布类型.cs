/*
 * C#2.0 分部类型
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVersionFeature
{
    public partial class CSharp2_分布类型
    {
        //使用partial修饰符，可以在不同文件中定义同一个类(结构、接口等)
        public static void Test1()
        {
            Console.WriteLine("执行分部类方法1");
        }
    }


    public partial class CSharp2_分布类型
    {
        //使用partial修饰符，可以在不同文件中定义同一个类(结构、接口等)
        public static void Test2()
        {
            Console.WriteLine("执行分部类方法2");
        }
    }

    public partial class CSharp2_分布类型
    {
        //使用partial修饰符，可以在不同文件中定义同一个类(结构、接口等)
        public static void Test3()
        {
            Console.WriteLine("执行分部类方法3");
        }
    }
}
