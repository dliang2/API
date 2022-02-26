using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace WebAPIClient
{
 
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }
        private static async Task ProcessRepositories()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Search a university. Press Enter without searching to quit the program.");
                    var searchTerm = Console.ReadLine();
                    if (string.IsNullOrEmpty(searchTerm))
                    {
                        break;
                    }
                    var result = await client.GetAsync("http://universities.hipolabs.com/search?name=" + searchTerm.ToLower());
                    var resultRead = await result.Content.ReadAsStringAsync();

                    dynamic universities = JsonConvert.DeserializeObject(resultRead);
                    if (universities.Count == 0)
                    {
                        Console.WriteLine("---\nERROR. No universities found!\n\n---");
                    }
                    foreach (var university in universities)
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("Name :" + university.name);
                        Console.WriteLine("Country :" + university.country);
                        Console.WriteLine("Website: " + university.web_pages[0]);
                        Console.WriteLine("\n---");
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR. No universities found!");
                }
            }
        }
    }
}