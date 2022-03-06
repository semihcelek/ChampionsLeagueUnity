using SemihCelek.ChampionsLeague.ChampionsLeague.Controllers;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models.DrawGroups;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches.GroupMatches;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches.KnockoutRounds;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models.Matches.QuarterFinalRounds;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models.PotGroups;
using SemihCelek.ChampionsLeague.ChampionsLeague.Persistence;
using SemihCelek.ChampionsLeague.ChampionsLeague.Persistence.Repositories;
using SemihCelek.ChampionsLeague.ChampionsLeague.Persistence.Repositories.TeamRepositories;
using SemihCelek.ChampionsLeague.ChampionsLeague.Utils;
using SemihCelek.ChampionsLeague.ChampionsLeague.Views;
using Zenject;

namespace SemihCelek.ChampionsLeague.ChampionsLeague
{
    public class LeagueInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ITeamDataPathFinder>().To<EditorTeamDataPathFinder>().AsSingle();
            Container.Bind<IStorageContext>().To<LocalStorageContext>().AsSingle();
            Container.Bind<IInitialTeamModelRepository>().To<InitialTeamModelRepository>().AsSingle();
            Container.Bind<IPotRepository>().To<PotRepository>().AsSingle();
            Container.Bind<IGroupRepository>().To<GroupRepository>().AsSingle();
            Container.Bind<IMatchRecordRepository>().To<MatchRecordRepository>().AsSingle();
            Container.Bind<TeamPotAdjuster>().AsSingle();
            Container.Bind<PotRandomizer>().AsSingle();
            Container.Bind<GroupDistributeController>().AsSingle();
            Container.Bind<PrepareGroupsController>().AsSingle();
            Container.Bind<IMatchPerformer>().To<GroupMatchPerformer>().AsSingle();

            Container.Bind<ITeamRankSort>().To<GroupMatchTeamSort>().AsSingle();
            Container.Bind<IGroupTeamReducer>().To<GroupMatchTeamReducer>().AsSingle();
            Container.Bind<TeamStatsReset>().AsSingle();

            Container.Bind<ILeagueMatchExecutor>().WithId("GroupMatchExecutor").To<GroupMatchExecutor>().AsSingle();
            Container.Bind<ExecuteGroupMatchesController>().AsSingle();

            Container.Bind<IDrawTeams>().WithId("KnockOutDraw").To<DrawKnockOutTeams>().AsSingle();
            Container.Bind<PrepareKnockOutMatchesController>().AsSingle();

            Container.Bind<ILeagueMatchExecutor>().WithId("KnockOutMatchExecutor").To<KnockoutMatchExecutor>()
                .AsSingle();
            Container.Bind<ExecuteKnockOutMatchesController>().AsSingle();

            Container.Bind<IDrawTeams>().WithId("QuarterFinalDraw").To<DrawFinalRoundTeam>().AsSingle();
            Container.Bind<PrepareQuarterFinalController>().AsSingle();
            Container.Bind<ExecuteQuarterFinalController>().AsSingle();

            Container.Bind<PrepareSemiFinalController>().AsSingle();
            Container.Bind<ExecuteSemiFinalController>().AsSingle();

            Container.Bind<PrepareFinalRound>().AsSingle();
            Container.Bind<FinalController>().AsSingle();
            
            Container.Bind<GroupMatchView>().AsSingle();

        }
    }
}