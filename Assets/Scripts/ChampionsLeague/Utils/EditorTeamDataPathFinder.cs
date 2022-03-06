using UnityEngine;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Utils
{
    public class EditorTeamDataPathFinder : ITeamDataPathFinder
    {
        private readonly string _projectDirectory;

        public EditorTeamDataPathFinder()
        {
            _projectDirectory = SetProjectDirectory();
        }

        private string SetProjectDirectory()
        {
            string applicationDirectory = Application.dataPath;
            return applicationDirectory;
        }

        public string GetTeamDataPath()
        {
            string teamDataPath = $"{_projectDirectory}/team-data.txt";
            return teamDataPath;
        }
    }
}