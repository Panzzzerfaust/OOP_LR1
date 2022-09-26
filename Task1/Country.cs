
namespace Task1
{
    public class Country
    {
        private string name;
        private string capital;
        private ulong population;

        #region Props
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public ulong Population
        {
            get { return population; }
            set { population = value; }
        }
        #endregion

        public Country()
        {
            name = "Ukraine";
            capital = "Kyiv";
            population = 41167336;
        }

        public Country(string name, string capital, ulong population)
        {
            this.name = name;
            this.capital = capital;
            this.population = population;
        }
    }
}
