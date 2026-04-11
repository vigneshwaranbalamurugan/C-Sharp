using System;
using System.Collections.Generic;
using System.Linq;

class Student{
    public string name;
    public float grade;
    public int age;

    public Student(string name,float grade, int age){
        this.name=name;
        this.grade=grade;
        this.age=age;
    }
}

class StudentManagement{
    static void Main(){
        List<Student> students= new List<Student>();
        students.Add(new Student("Vigneshwaran",8.5F,21));
        students.Add(new Student("Vijay",8.6F,21));
        students.Add(new Student("Shriram",8.2F,22));
        students.Add(new Student("Maha",9.0F,25));
        var filteredStudents = students.Where(s => s.grade >= 8.5).OrderBy(s => s.grade);
        Console.WriteLine("Students above or equal to 8.5:");
        foreach(var student in filteredStudents){
            Console.WriteLine("Name: "+student.name+", Grade: "+student.grade+", Age: "+student.age);
        }
    }
}