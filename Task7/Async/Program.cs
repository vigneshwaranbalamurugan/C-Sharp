using System;
using System.Threading.Tasks;
using System.Net.Http;

class Program{
    static async Task Main(){
        Console.WriteLine("Fetching data from multiple APIs...\n");

        try{
            Task<string> task1 = FetchUserData();
            Task<string> task2 = FetchPostData();
            Task<string> task3 = FetchCommentData();

            string[] results = await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("\nAll API data fetched successfully!");
            Console.WriteLine("\nAggregated Results:\n");

            foreach (var result in results){
                Console.WriteLine(result.Substring(0, 100));
            }
        }
        catch (Exception e){
            Console.WriteLine($"Error occurred: {e.Message}");
        }

        Console.WriteLine("\nProcess completed.");
    }

    static async Task<string> FetchUserData(){
        await Task.Delay(1500);
        using HttpClient client = new HttpClient();
        string response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users/1");
        return "User API Response:\n" + response;
    }

    static async Task<string> FetchPostData(){
        await Task.Delay(3000);
        using HttpClient client = new HttpClient();
        string response =await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
        return "Post API Response:\n" + response;
    }

    static async Task<string> FetchCommentData(){
        await Task.Delay(1000);
        using HttpClient client = new HttpClient();
        string response =await client.GetStringAsync("https://jsonplaceholder.typicode.com/comments/1");
        return "Comment API Response:\n" + response;
    }
}