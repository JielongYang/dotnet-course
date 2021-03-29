using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number of classes:");
            int classNum = Convert.ToInt16(Console.ReadLine()); 
            Class[] classes = new Class[classNum];
            for (int i = 0; i < classNum; i++)
            {
                classes[i] = new Class();
                Console.WriteLine("number of students in class {0} :",i+1);
                int studentNum = Convert.ToInt16(Console.ReadLine());
                for (int j = 0; j < studentNum; j++)
                {
        
                    Console.WriteLine("Chinese grade of student {0}:",j+1);
                    int grade = Convert.ToInt16(Console.ReadLine()); 
                    classes[i].list.Add(new Student(grade));
                }
                Console.WriteLine("The average Chinese grades of class {0} is {1}.",i+1,classes[i].getChineseAeverage());
            }
            
            
            
        }
    }
}