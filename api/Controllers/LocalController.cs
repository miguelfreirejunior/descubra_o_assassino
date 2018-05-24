using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    /// <summary>
    /// Controlador das operações de locais
    /// </summary>
    [Route("api/locais")]
    public class LocalController : Controller
    {
        private readonly ILocalService _localService;

        public LocalController(ILocalService localService)
        {
            this._localService = localService;
        }


        /// <summary>
        /// Lista os possíveis locais
        /// </summary>
        /// <returns>Possíveis locais</returns>
        [HttpGet]
        public async Task<IEnumerable<Local>> Create(){
            return await this._localService.List();
        }
    }
}
