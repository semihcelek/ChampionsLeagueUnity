using System;
using SemihCelek.ChampionsLeague.ChampionsLeague.Controllers;
using UnityEngine;
using Zenject;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Views
{
    public class GroupMatchView : MonoBehaviour
    {
        private PrepareGroupsController _prepareGroupsController;
        private ExecuteGroupMatchesController _executeGroupMatchesController;
        
        [Inject]
        private void Construct(PrepareGroupsController prepareGroupsController, ExecuteGroupMatchesController executeGroupMatchesController)
        {
            _prepareGroupsController = prepareGroupsController;
            _executeGroupMatchesController = executeGroupMatchesController;
        }

        private void Start()
        {
            _prepareGroupsController.PrepareGroupsForStartingGroupMatches();
            
            _executeGroupMatchesController.ExecuteGroupMatches();
        }
    }
}