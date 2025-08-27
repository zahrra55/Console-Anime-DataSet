using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeApp
{
    internal class JsonHandler
    {
        public static string JsonPath = "E:\\Problems_Solver_Bootcamp\\VS_projects\\AnimeApp\\animes.json";
        public static List<Anime> animeList = new List<Anime>();

        // Jason loader
        public static void LoadJson()
        {
            
            string GetJson = System.IO.File.ReadAllText(JsonPath);

            animeList = System.Text.Json.JsonSerializer.Deserialize<List<Anime>>(GetJson);

            foreach (var anime in animeList)
            {
                Console.WriteLine($"{ anime.Id}, {anime.Title}");
            }
        }
        public static void AddAnime()
        {
            Console.WriteLine("Adding new anime...\nEnter Anime Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Anime Year:");
            string year = Console.ReadLine();
            Console.WriteLine("Enter Anime Episodes:");
            int episodes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Anime Rating:");
            double rating = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Anime Genre:");
            string genre = Console.ReadLine();

            // write to json file
            int newId = animeList.Count == 0 ? 1 : animeList.Max(a => a.Id) + 1;
            // newId means if the list is empty, assign 1 else assign max id + 1
            animeList.Add(new Anime { Id = newId, Title = title, Year = year, Episodes = episodes, Rating = rating, Genre = genre });
            var json = System.Text.Json.JsonSerializer.Serialize(animeList);
            System.IO.File.WriteAllText(JsonPath, json);

            Console.WriteLine("Anime added successfully!");
        }

        public static void GetAnimeDetails(int id)
        {
            var animeToGet = animeList.FirstOrDefault(a => a.Id == id);
            if (animeToGet == null)
            {
                Console.WriteLine("Anime not found!");
                return;
            }
            Console.WriteLine($"Anime Title:{animeToGet.Title}, Year:{animeToGet.Year}, Genre:{animeToGet.Genre}, Episodes{animeToGet.Episodes}, Rating:{animeToGet.Rating}");
        }

        public static void EditAnime()
        {
            Console.WriteLine("Enter the Anime Id to edit: ");
            int animeId = int.Parse(Console.ReadLine());

            var animeToEdit = animeList.FirstOrDefault(a => a.Id == animeId);
            if (animeToEdit == null)
            {
                Console.WriteLine("Anime not found!");
                return;
            }

            Console.WriteLine($"Editing anime: {animeToEdit.Title}");
            
            Console.WriteLine("Enter new Title (press Enter to keep current value):");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
                animeToEdit.Title = input;

            Console.WriteLine("Enter new Year (press Enter to keep current value):");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
                animeToEdit.Year = input;

            Console.WriteLine("Enter new Episodes (press Enter to keep current value):");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int episodes))
                animeToEdit.Episodes = episodes;

            Console.WriteLine("Enter new Rating (press Enter to keep current value):");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && double.TryParse(input, out double rating))
                animeToEdit.Rating = rating;

            Console.WriteLine("Enter new Genre (press Enter to keep current value):");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
                animeToEdit.Genre = input;

            // Serialize and save the updated list back to the JSON file
            var json = System.Text.Json.JsonSerializer.Serialize(animeList);
            System.IO.File.WriteAllText(JsonPath, json);

            Console.WriteLine("Anime updated successfully!");
        }
    }
}
    