﻿using System;

delegate void NumberChanger(int n);

namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;
        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            // 使用匿名方法创建委托实例
            NumberChanger nc = delegate(int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            // 使用匿名方法调用委托
            nc(10);

            // 使用命名方法实例化委托
            nc = new NumberChanger(AddNum);

            // 使用命名方法调用委托
            nc(5);

            // 使用另一个命名方法实例化委托
            nc = new NumberChanger(MultNum);

            // 使用命名方法调用委托
            nc(2);
            Console.ReadKey();
        }
    }
}