using IDHLDeveloperTest.Models;

namespace IDHLDeveloperTest.Services
{
    public interface IClientService
    {
        Task<CharacterList> GetCharacters(int pageNumber);
        Task<CharacterInfo> GetCharacter(int id);
        Task<CharacterList> GetCharactersByName(string name);
    }
}
