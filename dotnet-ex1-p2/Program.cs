using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zhang = new Student("张三",90,72,70);
            Student li = new Student("李四",85,69,72);
            Class class1 = new Class();
            class1.list.Add(zhang);
            class1.list.Add(li);
            Console.WriteLine(class1.getChineseAeverage());
            
            
        }
    }
}
