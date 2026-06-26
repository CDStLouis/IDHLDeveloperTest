namespace IDHLDeveloperTest.Models
{
    public class CharacterList
    {
        public IEnumerable<Character> Data { get; set; } = new List<Character>();
        public CharacterListInfo Info { get; set; } = new CharacterListInfo();
    }
}
