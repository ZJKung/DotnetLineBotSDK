using System.Threading.Tasks;
using DotnetcoreLineBot.Models.Line;

namespace DotnetcoreLineBot.Interfaces
{
    public interface ILineProfileService
    {
        Task<UserProfile> GetUserProfile(string userId);
    }
}