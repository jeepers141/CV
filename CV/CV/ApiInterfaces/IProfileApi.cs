using System.Threading.Tasks;
using CV.Controllers;
using Refit;

namespace CV.ApiInterfaces
{
    public interface IProfileApi
    {
        [Get("/profile/")]
        Task<ProfileDataController.Profile> GetProfile();
    }
}
