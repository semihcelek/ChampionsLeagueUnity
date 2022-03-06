using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches;
using Zenject;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Controllers
{
    public class ExecuteGroupMatchesController
    {
        [Inject(Id="GroupMatchExecutor")]
        private ILeagueMatchExecutor _groupMatchExecutor;

        public ExecuteGroupMatchesController(ILeagueMatchExecutor groupMatchExecutor)
        {
            _groupMatchExecutor = groupMatchExecutor;
        }

        public void ExecuteGroupMatches()
        {
            _groupMatchExecutor.ActLeagueMatches();
        }
    }
}