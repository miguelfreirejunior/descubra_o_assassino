using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public interface ILocalService
    {
         Task<IQueryable<Local>> List();

         Task<Local> Random();
    }
}