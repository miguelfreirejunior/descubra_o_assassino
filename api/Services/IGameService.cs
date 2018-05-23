using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public interface IGameService
    {
         Task<Game> create();
    }
}