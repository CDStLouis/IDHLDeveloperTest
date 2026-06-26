using IDHLDeveloperTest.Models;

namespace IDHLDeveloperTest.Services
{
    public interface IClientService
    {
        Task<CharacterList> GetAllCharacters();
        Task<CharacterList> GetCharacters(int pageNumber);
        Task<CharacterInfo> GetCharacter(int id);
    }
}
