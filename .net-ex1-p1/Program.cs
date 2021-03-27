using System;

namespace c__helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student zhang = new Student("张三",90,72,70);
            Student li = new Student("李四",85,69,72);
            Student wang = new Student("王五",72,88,79);
            Student chen = new Student("陈七",95,56,88);
            Student zhao = new Student("赵八",70,77,86);
            Student wu = new Student("吴九",60,70,82);
            Student lu = new Student("陆十",65,80,84);

            Student[] list = new Student[]{zhang,li,wang,chen,zhao,wu,lu};

            for(int i=0;i<list.Length;i++) {
                for(int j=i;j<list.Length;j++){
                    if(list[j].getSum() > list[i].getSum()){
                        Student temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                Console.WriteLine(list[i].Name + ","+list[i].getSum()+" "+list[i].Chinese+" "+list[i].Math+" "+list[i].English);
            }

            
            
            
        }
    }
}
