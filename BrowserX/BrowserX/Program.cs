using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BrowserX
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        private static async Task ProcessRepositories(string url)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync(url);
            var msg = await stringTask;

            Console.Write(msg);
        }

        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ________                                          ____  __");
            Console.WriteLine(" ___  __ )_______________      ______________________  |/ /");
            Console.WriteLine(" __  __  |_  ___/  __ \\_ | /| / /_  ___/  _ \\_  ___/_    /");
            Console.WriteLine(" _  /_/ /_  /   / /_/ /_ |/ |/ /_(__  )/  __/  /   _    |");
            Console.WriteLine(" /_____/ /_/    \\____/____/|__/ /____/ \\___//_/    /_/|_|");
            Console.WriteLine("                                                          ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" §: ");
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            await ProcessRepositories(input);
        }
    }
}
