using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Controllers
{
    public class ExecuteSemiFinalController
    {
        private ILeagueMatchExecutor _semiFinalExecutor;

        public ExecuteSemiFinalController(ILeagueMatchExecutor semiFinalExecutor)
        {
            _semiFinalExecutor = semiFinalExecutor;
        }

        public void ExecuteSemiFinalMatches()
        {
            _semiFinalExecutor.ActLeagueMatches();
        }
    }
}