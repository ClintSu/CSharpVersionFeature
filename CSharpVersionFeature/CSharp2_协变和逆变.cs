using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpVersionFeature
{
    public class CSharp2_协变和逆变
    {
        // 协变和逆变能够实现数组类型、委托类型和泛型类型参数的隐式引用转换。 协变保留分配兼容性，逆变则与之相反。
        //“协变”是指能够使用与原始指定的派生类型相比，派生程度更大的类型。 
        //“逆变”则是指能够使用派生程度更小的类型
        // mk: https://www.cnblogs.com/qixuejia/p/4383068.html
        public static void Test()
        {
            //Assignment compatibility.
            string str = "test";
            // An object of a more derived type is assigned to an object of a less derived type.   
            object obj = str;

            // Covariance.   
            IEnumerable<string> strings = new List<string>();
            // An object that is instantiated with a more derived type argument   
            // is assigned to an object instantiated with a less derived type argument.   
            // Assignment compatibility is preserved.   
            IEnumerable<object> objects = strings;

            // Contravariance.             
            // Assume that the following method is in the class:   
            static void SetObject(object o) { }   
            Action<object> actObject = SetObject;
            // An object that is instantiated with a less derived type argument   
            // is assigned to an object instantiated with a more derived type argument.   
            // Assignment compatibility is reversed.   
            Action<string> actString = actObject;
        }
    }
}
