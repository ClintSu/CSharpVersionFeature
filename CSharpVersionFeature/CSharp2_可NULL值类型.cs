using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Text;

namespace CSharpVersionFeature
{
    public class CSharp2_可NULL值类型
    {
        public static void Test()
        {
            double? pi = 3.14;
            char? letter = 'a';

            int m = 10;
            int? m2 = m;

            bool? flag = null;

            int?[] arr = new int?[10];

            Console.WriteLine("bool? flag值:" + flag);

        }
    }
}
