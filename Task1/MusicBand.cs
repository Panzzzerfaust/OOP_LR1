using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class MusicBand
    {
        private string name;
        private List<Member> members;
        private Country origin;
        private string genres;

        #region Props
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Member> Members
        {
            get { return members; }
            set { members = value; }
        }

        public Country Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Genres
        {
            get { return genres; }
            set { genres = value; }
        }
        #endregion

        public MusicBand()
        {
            name = "Queen";
            origin = new Country("England", "London", 56489800);
            members = new List<Member>() { new Member("Farrokh", "Bulsara", "Freddie Mercury", new DateTime(1946, 9, 5), new DateTime(1991, 11, 24), origin), new Member("John", "Deacon", null, new DateTime(1951, 8, 19), null, origin), new Member("Brian", "May", null, new DateTime(1947, 7, 19), null, origin), new Member("Roger", "Taylor", null, new DateTime(1949, 7, 26), null, origin) };
            genres = "Rock";
        }

        public MusicBand(string name, List<Member> members, Country origin, string genres)
        {
            this.name = name;
            this.members = members;
            this.origin = origin;
            this.genres = genres;
        }

        public void AddMember(Member member) 
        {
            members.Add(member);
        }

        public void FindByName(string name)
        {
            if (this.name == name)
            {
                Console.WriteLine($"{this.name} ({origin.Name}) | {genres} ");
                Console.WriteLine(new string('=', 20));
                foreach (Member mem in members)
                {
                    Console.WriteLine($"{mem.Pseudonym} | {mem.Name} {mem.Surname} ({mem.Birth.ToString("MM/dd/yyyy")} - {mem.Death?.ToString("MM/dd/yyyy")})");
                }
                Console.WriteLine(new string('=', 20));
                Console.WriteLine();
            }
        }
        public void FindMembersByName(string name)
        {
            List<Member> search = members.Where(x => x.Name == name).ToList();
            foreach (Member mem in search)
            {
                Console.WriteLine($"{mem.Name} {mem.Surname} ({mem.Birth.ToString("MM/dd/yyyy")} - {mem.Death?.ToString("MM/dd/yyyy")})");
            }
        }
    }
}
