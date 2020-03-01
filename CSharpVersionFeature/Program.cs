using System;

namespace CSharpVersionFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharp2_泛型.Test();
            CSharp2_分布类型.Test1();
            CSharp2_分布类型.Test2();
            CSharp2_分布类型.Test3();
            CSharp2_可NULL值类型.Test();
            CSharp2_匿名方法.Test();
            CSharp2_迭代器.Test();
            CSharp2_协变和逆变.Test();

            Console.ReadLine();
        }
    }
}
