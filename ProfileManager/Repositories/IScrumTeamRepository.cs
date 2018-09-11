using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface IScrumTeamRepository
    {
        IEnumerable<ScrumTeam> GetAllScrumTeams();
        ScrumTeam GetScrumTeamById(int scrumTeamId);
    }
}