using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Controllers
{
    public class FinalController
    {
        private ILeagueMatchExecutor _finalMatch;

        public FinalController(ILeagueMatchExecutor finalMatch)
        {
            _finalMatch = finalMatch;
        }

        public void ExecuteFinalMatch()
        {
            _finalMatch.ActLeagueMatches();
        }
        
        
    }
}