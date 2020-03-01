/*
 * C#2.0 泛型
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVersionFeature
{

    public class CSharp2_泛型
    {
        public class GenericList<T>
        {
            public void Add(T input) { }
        }

        public class ExampleClass { }

        public static void Test()
        {
            //int 类型列表
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            Console.WriteLine("泛型列表中加入int");

            //string 类型列表
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");

            Console.WriteLine("泛型列表中加入string");

            //class 类型列表
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());

            Console.WriteLine("泛型列表中加入class");
        }

    }
}
