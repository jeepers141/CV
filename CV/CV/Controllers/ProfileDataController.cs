using System.Threading.Tasks;
using CV.ApiInterfaces;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace CV.Controllers
{
    [Route("api/[controller]")]
    public class ProfileDataController : Controller
    {
        [HttpGet("[action]")]
        public async Task<Profile> ProfileDetails()
        {
            var gitHubApi = RestService.For<IProfileApi>("https://cvprofile.azurewebsites.net/api/profile");

            var response = await gitHubApi.GetProfile();

            return new Profile();
        }


        [HttpGet("[action]")]
        public Profile ProfileDetails2()
        {
            return new Profile();
        }

        public class Profile
        {
            public string FirstName { get; set; }
            public int LastName { get; set; }
        }
    }
}
