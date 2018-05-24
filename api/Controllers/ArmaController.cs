using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    /// <summary>
    /// Controlador das operações de armas
    /// </summary>
    [Route("api/armas")]
    public class ArmaController : Controller
    {
        private readonly IArmaService _armaService;

        public ArmaController(IArmaService armaService)
        {
            this._armaService = armaService;
        }


        /// <summary>
        /// Lista as armas disponíveis
        /// </summary>
        /// <returns>Possíveis Armas</returns>
        [HttpGet]
        public async Task<IEnumerable<Arma>> Create(){
            return await this._armaService.List();
        }
    }
}
