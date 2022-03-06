using System.Collections.Generic;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches.MatchResults
{
    public interface IMatchResultStatus
    {
        List<ITeamModel> GetCompetingTeams();
        string GetMatchResult();
    }
}