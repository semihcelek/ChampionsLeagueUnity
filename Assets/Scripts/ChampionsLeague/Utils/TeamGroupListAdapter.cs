using System.Collections.Generic;
using SemihCelek.ChampionsLeague.ChampionsLeague.Models;
using SemihCelek.ChampionsLeague.ChampionsLeague.Persistence.Repositories;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Utils
{
    public static class TeamGroupListAdapter
    {
        public static void LowerRepositoryListCapacityForNextPhase(IGroupRepository groupRepository)
        {
            List<IGroupModel> groups = groupRepository.GetAllGroups();

            int numberOfGroupToRemove = groups.Count / 2;
            for (int i = 0; i < numberOfGroupToRemove; i++)
            {
                groups.RemoveAt(groups.Count-1);
            }
        }
    }
}