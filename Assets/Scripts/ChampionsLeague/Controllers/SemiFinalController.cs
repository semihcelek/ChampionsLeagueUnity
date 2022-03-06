using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Controllers
{
    public class SemiFinalController
    {
        private ILeagueMatchExecutor _semiFinalExecutor;

        public SemiFinalController(ILeagueMatchExecutor semiFinalExecutor)
        {
            _semiFinalExecutor = semiFinalExecutor;
        }

        public void ExecuteSemiFinalMatches()
        {
            _semiFinalExecutor.ActLeagueMatches();
        }
    }
}