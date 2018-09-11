using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetAllTeams();
        Team GeTeamById(int teamId);
    }
}