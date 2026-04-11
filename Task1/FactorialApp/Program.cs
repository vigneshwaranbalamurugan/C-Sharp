using System;

class Factorial{
    int factorial(int n){
        if(n==0 || n==1){
            return 1;
        }
        return n*factorial(n-1);
    }

    public static void Main(){
        Console.Write("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num<0){
            Console.Write("Enter Positive number");
            return;
        }
        Console.WriteLine("Entered number is: " + num);
        int fact =1;
        for(int i=1;i<=num;i++){
            fact *= i;
        }
        Console.WriteLine("Factorial of " + num + " is: " + fact);
        Factorial f = new Factorial();
        Console.WriteLine("Factorial of " + num + " is: " + f.factorial(num));
    }
}