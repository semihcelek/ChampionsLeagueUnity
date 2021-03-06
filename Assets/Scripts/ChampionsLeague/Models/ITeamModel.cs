namespace SemihCelek.ChampionsLeague.ChampionsLeague.Models
{
    public interface ITeamModel
    {
        string GetTeamName();
        string GetTeamCountryCode();
        int GetPoints();
        int GetGoals();
        void AddPoints(int point);
        void AddGoals(int goals);
        void ResetPoint();
        void ResetGoals();

    }
}