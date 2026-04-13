using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class LoginAttribute : Attribute{
}

public class LoginTasks{
    [LoginAttribute]
    public void SendOTP(){
        Console.WriteLine("OTP sent to your mobile number");
    }

    [LoginAttribute]
    public void VerifyOTP(){
        Console.WriteLine("OTP verified successfully");
    }

    [LoginAttribute]
    public void ShowWelcomeMessage(){
        Console.WriteLine("Login successful. Welcome user!");
    }

    public void ErrorMessage(){
        Console.WriteLine("Wrong OTP. Please try again.");
    }
}

class Program{
    static void Main(){

        Assembly assembly = Assembly.GetExecutingAssembly();

        foreach (Type type in assembly.GetTypes()){
            foreach (MethodInfo method in type.GetMethods()){
                if (method.GetCustomAttribute(typeof(LoginAttribute)) != null){
                    object obj = Activator.CreateInstance(type);
                    Console.WriteLine($"Running: {method.Name}");
                    method.Invoke(obj, null);
                }
            }
        }

        Console.WriteLine("\nProcess completed");
    }
}