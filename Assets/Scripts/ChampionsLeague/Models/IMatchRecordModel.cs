using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches.MatchResults;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Models
{
    public interface IMatchRecordModel
    {
        ITeamModel GetHomeTeam();
        ITeamModel GetAwayTeam();
        IMatchResultStatus GetMatchResult();
        
    }
}