using SWCCGO.Models;

namespace SWCCGO.DataLoader
{

    public class StarWarsGameCardProperties
    {
        public IGameCardDynamicProperty Lore { get; set; }
        public IGameCardDiscreteProperty Side { get; set; }
        public IGameCardDiscreteProperty Category { get; set; }

    }

    public class StarWarsRulesMeta : ICardGameRulesMeta<StarWarsGameCardProperties>
    {
        public string GameName => "SwCCG";

        public string GameFriendlyName => "Star Wars CCG";

        public StarWarsGameCardProperties GameCardProperties => new StarWarsGameCardProperties();
    }
    public class StarWarsGameLoader
    {
        public StarWarsGameLoader() { }

        public ICardGameRulesMeta<StarWarsGameCardProperties> LoadGame()
        {
            var bob = new StarWarsRulesMeta();

            return bob;
        }
    }
}
