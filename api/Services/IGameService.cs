using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    /// <summary>
    /// Serviço que controla as operações relacionadas ao jogo
    /// </summary>
    public interface IGameService
    {
        /// <summary>
        /// Inicia um novo jogo
        /// </summary>
        /// <returns>Identificador único do jogo</returns>
         Task<string> Create();


        /// <summary>
        /// Efetua a validação de um palpite
        /// </summary>
        /// <param name="guess">Palpite dado</param>
        /// <returns>
        ///     0 - indica palpite certeiro
        ///     1 - indica que o assassino está incorreto
        ///     2 - indica que o local está incorreto
        ///     3 - indica que a arma está incorreta 
        /// </returns>
        Task<short> Guess(Guess guess);
    }
}