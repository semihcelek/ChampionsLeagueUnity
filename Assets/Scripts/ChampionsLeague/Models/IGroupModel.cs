using System.Collections.Generic;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Models
{
    public interface IGroupModel
    {
        char GetGroupName();
        List<ITeamModel> GetCompetingTeamsList();
        void AddTeamToGroup(ITeamModel teamToAdd);
    }
}