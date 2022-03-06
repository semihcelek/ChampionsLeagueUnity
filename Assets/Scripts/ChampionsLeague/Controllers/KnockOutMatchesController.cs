using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches;
using Zenject;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Controllers
{
    public class ExecuteKnockOutMatchesController
    {
        [Inject(Id = "KnockOutMatchExecutor")]
        private ILeagueMatchExecutor _knockoutMatchExecutor;

        public ExecuteKnockOutMatchesController(ILeagueMatchExecutor knockoutMatchExecutor)
        {
            _knockoutMatchExecutor = knockoutMatchExecutor;
        }

        public void ExecuteKnockOutMatches()
        {
            _knockoutMatchExecutor.ActLeagueMatches();
        }
    }
}