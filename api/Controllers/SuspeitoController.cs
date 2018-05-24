using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    /// <summary>
    /// Controlador das operações de suspeitos
    /// </summary>
    [Route("api/suspeitos")]
    public class SuspeitoController : Controller
    {
        private readonly ISuspeitoService _suspeitoService;

        public SuspeitoController(ISuspeitoService suspeitoService)
        {
            this._suspeitoService = suspeitoService;
        }


        /// <summary>
        /// Lista os prováveis suspeitos
        /// </summary>
        /// <returns>Possíveis Suspeitos</returns>
        [HttpGet]
        public async Task<IEnumerable<Suspeito>> Create(){
            return await this._suspeitoService.List();
        }
    }
}
