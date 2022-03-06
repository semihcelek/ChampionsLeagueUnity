namespace SemihCelek.ChampionsLeague.ChampionsLeague.Models
{
    public interface IInitialTeamModel
    {
        string GetTeamName();
        string GetTeamCountryCode();
        int GetSeedPoint();
    }
}