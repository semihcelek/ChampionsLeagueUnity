using SemihCelek.ChampionsLeague.ChampionsLeague.Models;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models.DrawGroups;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Utils
{
    public class TeamModelConverter
    {
        public ITeamModel ConvertInitialTeamModelToTeamModel(IInitialTeamModel initialTeamModel)
        {
            ITeamModel teamModel = new TeamModel(initialTeamModel.GetTeamName(), initialTeamModel.GetTeamCountryCode());
            return teamModel;
        }
    }
}