using System;

namespace Task1
{
    public class Member
    {
        private string name;
        private string surname;
        private string pseudonym;
        private DateTime birth;
        private DateTime? death;
        private Country country;

        #region Props
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Pseudonym
        {
            get { return pseudonym; }
            set { pseudonym = value; }
        }

        public DateTime Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public DateTime? Death
        {
            get { return death; }
            set { death = value; }
        }

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }
        #endregion

        public Member()
        {
            name = "David";
            surname = "Jones";
            pseudonym = "Bowie";
            birth = new DateTime(1947, 1, 8);
            death = new DateTime(2016, 1, 10);
            country = new Country("England", "London", 56489800);
        }

        public Member(string name, string surname, string pseudonym, DateTime birth, DateTime? death, Country country)
        {
            this.name = name;
            this.surname = surname;
            this.pseudonym = pseudonym;
            this.birth = birth;
            this.death = death;
            this.country = country;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Birth.ToString("MM/dd/yyyy")} - {Death?.ToString("MM/dd/yyyy")})\n";
        }
    }
}
