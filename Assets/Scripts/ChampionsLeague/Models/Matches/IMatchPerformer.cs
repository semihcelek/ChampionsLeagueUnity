namespace SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches
{
    public interface IMatchPerformer
    {
        void PerformMatch(ITeamModel homeTeam, ITeamModel awayTeam);
    }
}