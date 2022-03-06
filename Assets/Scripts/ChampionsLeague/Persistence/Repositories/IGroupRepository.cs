using System.Collections.Generic;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Persistence.Repositories
{
    public interface IGroupRepository
    {
        List<IGroupModel> GetAllGroups();
    }
}