using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, AnimeApp!");
            JsonHandler.LoadJson();
            Console.WriteLine();
            //JsonHandler.AddAnime();
            //JsonHandler.LoadJson();
            JsonHandler.GetAnimeDetails(1);
            JsonHandler.EditAnime();
            JsonHandler.GetAnimeDetails(1);

        }
    }
}