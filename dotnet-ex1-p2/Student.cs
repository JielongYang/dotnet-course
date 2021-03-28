
public class Student{
    public string Name {get;}
    public int Chinese {get;}
    public int Math {get;}

    public int English{get;}

    public int Sum;

    public Student(string name, int chinese,int math,int english) => (Name,Chinese,Math,English) = (name,chinese,math,english);

    public int getSum(){
        Sum = Chinese + Math + English;
        return Sum;
    }

}