using System.Threading.Tasks;
using System.Linq;
using api.Models;

namespace api.Services
{
    public interface ISuspeitoService
    {
         Task<IQueryable<Suspeito>> List();

         Task<Suspeito> Random();
    }
}