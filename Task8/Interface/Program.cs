using System;

public class Student : IEntity{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program{
    static void Main(){
        Repository<Student> repo = new Repository<Student>();

        while (true){
            Console.WriteLine("\n1.Add 2.View 3.Update 4.Delete 5.Exit");
            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1){
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                repo.Add(new Student { Id = id, Name = name });

                Console.WriteLine("Added!");
            }
            else if (choice == 2){
                foreach (var s in repo.GetAll()){
                    Console.WriteLine($"{s.Id} - {s.Name}");
                }
            }
            else if (choice == 3){
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("New Name: ");
                string name = Console.ReadLine();

                repo.Update(new Student { Id = id, Name = name });

                Console.WriteLine("Updated!");
            }
            else if (choice == 4){
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                repo.Delete(id);

                Console.WriteLine("Deleted!");
            }
            else if (choice == 5){
                break;
            }
        }
    }
}