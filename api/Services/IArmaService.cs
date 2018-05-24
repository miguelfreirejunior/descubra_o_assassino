using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public interface IArmaService
    {
         Task<IQueryable<Arma>> List();

         Task<Arma> Random();
    }
}