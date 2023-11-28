namespace Lab_14_s_chasrp.Models
{
    public class Models
    {

        public List<CountryModel> Countryes { get; }
        public List<ContinentModel> Continents { get; }

        

        public Models(List<CountryModel> countryes, List<ContinentModel> continents)
        {
            Countryes = countryes;
            Continents = continents;
        }
    }
}
