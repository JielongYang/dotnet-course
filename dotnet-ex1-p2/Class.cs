using System.Collections.Generic;

public class Class{
    public List<Student> list = new List<Student>();
    int sum;
    int average;

    public int getChineseAeverage() {
        sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i].Chinese;
        }
        average = sum/list.Count;
        return average;
    }
 
}