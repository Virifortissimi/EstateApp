using System.Threading.Tasks;
using EstateApp.Data.Entities;
using EstateApp.Web.Models;

namespace EstateApp.Web.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateAsycn(RegisterModel model);
    }
}