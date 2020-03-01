using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVersionFeature
{
    public class CSharp2_迭代器
    {

        public static void Test()
        {
            foreach (var item in SomEnumerable())
            {
                Console.WriteLine(item.ToString());
            }
        }


        public static System.Collections.IEnumerable SomEnumerable()
        {
            yield return 3;
            yield return 5;
            yield return 6;
            yield return 9;
        }
    }
}
