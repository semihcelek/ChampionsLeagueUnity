using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches;
using Zenject;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Controllers
{
    public class ExecuteGroupMatchesController
    {
        private ILeagueMatchExecutor _groupMatchExecutor;

        public ExecuteGroupMatchesController
            (
            [Inject(Id = "GroupMatchExecutor")] 
            ILeagueMatchExecutor groupMatchExecutor
            )
        {
            _groupMatchExecutor = groupMatchExecutor;
        }

        public void ExecuteGroupMatches()
        {
            _groupMatchExecutor.ActLeagueMatches();
        }
    }
}