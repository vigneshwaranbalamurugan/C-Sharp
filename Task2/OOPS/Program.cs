class Person{
    string name;
    int age;

    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    void Introduce(){
        Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
    }

    static void Main(){
        Person p1 = new Person("Vigneshwaran", 22);
        p1.Introduce();
        Person p2 = new Person("Vijay Bharath", 22);
        p2.Introduce();
        Person p3 = new Person("Mahaselvan", 23);
        p3.Introduce();
    }
}