using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicBand queen = new MusicBand();
            MusicBand anotherQueen = new MusicBand("Queen", new List<Member>() { new Member("Elizabeth", "II", null, new DateTime(1926, 4, 21), new DateTime(2022, 9, 8), new Country("England", "London", 56489800)) }, new Country("England", "London", 56489800), "Rock");
            MusicBand notQueen = new MusicBand("The Beatles", new List<Member>() { new Member("John", "Lennon", null, new DateTime(1940, 10, 9), new DateTime(1980, 12, 8), new Country("England", "London", 56489800)), new Member("Paul", "McCartney", null, new DateTime(1942, 6, 18), null, new Country("England", "London", 56489800)), new Member("Richard", "Starkey", "Ringo Starr", new DateTime(1940, 7, 7), null, new Country("England", "London", 56489800)), new Member("George", "Harrison", null, new DateTime(1943, 2, 25), new DateTime(2001, 11, 29), new Country("England", "London", 56489800)) }, new Country("England", "London", 56489800), "Rock");
            List<MusicBand> bands = new List<MusicBand>() { queen, anotherQueen, notQueen};
            Console.WriteLine("All bands:");
            foreach (MusicBand band in bands)
            {
                Console.WriteLine(band.ToString());
            }
            Console.WriteLine("Search by band name");
            Console.WriteLine("Enter name to search: ");
            string bname = Console.ReadLine();
            foreach (MusicBand band in bands)
            {
                band.FindByName(bname);
            }
            Console.WriteLine("Search members by name");
            Console.WriteLine("Enter name to search: ");
            string name = Console.ReadLine();
            foreach (MusicBand band in bands)
            {
                band.FindMembersByName(name);
            }
            Console.ReadKey();
        }
    }
}
