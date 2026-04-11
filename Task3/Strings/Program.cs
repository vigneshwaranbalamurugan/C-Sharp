using System;
using System.Collections.Generic;

class Program{
    static void Main(){
        List<string> rollnos = new List<string>();
        while(true){
            Console.WriteLine("Enter a Number");
            Console.WriteLine("1. Add Roll");
            Console.WriteLine("2. Remove Roll");
            Console.WriteLine("3. Display Roll");
            Console.WriteLine("4. Exit");

            int num = Convert.ToInt32(Console.ReadLine());
            if(num==1){
                Console.Write("Enter Rollno to add: ");
                string rollno = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(rollno))
                {
                    rollnos.Add(rollno);
                    Console.WriteLine("Rollno added successfully.");
                }
                else
                {
                    Console.WriteLine("Rollno cannot be empty.");
                }
            }
            else if (num == 2){
                Console.Write("Enter rolno to remove: ");
                string rollno = Console.ReadLine().Trim();
                if (rollnos.Remove(rollno)){
                    Console.WriteLine("Rollno removed successfully.");
                }
                else{
                    Console.WriteLine("Rollno not found.");
                }
            }
            else if (num == 3){
                Console.WriteLine("Rollnos in list:");
                if (rollnos.Count == 0){
                    Console.WriteLine("List is empty.");
                }
                else{
                    foreach (string rollno in rollnos){
                        Console.WriteLine(rollno.ToUpper());
                    }
                }
            }
            else if (num == 4){
                Console.WriteLine("Exiting program...");
                break;
            }
            else{
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}