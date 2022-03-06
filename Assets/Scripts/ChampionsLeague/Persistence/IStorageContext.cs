using System.Collections.Generic;

namespace SemihCelek.ChampionsLeague.ChampionsLeague.Persistence
{
    public interface IStorageContext
    {
        List<string> ReadAllLines();
    }
}