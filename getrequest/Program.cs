using System;
using System.Net;
using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        string API_URL = "https://jsonplaceholder.typicode.com/todos?_limit=5";
        var client = new WebClient();
        var json = client.DownloadString(API_URL);
        dynamic posts = JsonConvert.DeserializeObject(json);

        foreach (var post in posts)
        {
            Console.WriteLine(post.id + ": "+ post.title);
        }
    }
}