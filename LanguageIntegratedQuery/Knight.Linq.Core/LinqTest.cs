using System;
using System.Collections.Generic;
using System.Linq;

namespace Knight.Linq.Core
{
    public partial class LinqTest
    {
        /// <summary>
        /// 差集
        /// </summary>
        public void TestExcept()
        {
            List<string> list4 = new List<string> { "yuanjy@yiche.com" };
            List<string> list5 = new List<string> { "yuanjy@yiche.com", "wangjiahui3@yiche.com" };
            var list6 = list4.Except(list5).ToList();
            Console.WriteLine(list6.Count);
            foreach (var s in list6)      // 各个值
            {
                Console.Write(s);
            }

        }
        /// <summary>
        /// 聚合
        /// </summary>
        public void TestAggregate()
        {
            var list = new List<String> { "yuanjy@yiche.com", "wangjiahui3@yiche.com", "abc@qq.com", "564@163.com" };
            var str1 = list.Aggregate((e1, e2) => $"{e1};{e2}");
            Console.WriteLine(str1);

            var list2 = new List<String> { "yuanjy@yiche.com", "wangjiahui3@yiche.com", "abc@qq.com", "564@163.com" };
            var str2 = list2.Aggregate("seed@seed.com",(e1, e2) => $"{e1};{e2}");
            Console.WriteLine(str2);
        }
    }
}
