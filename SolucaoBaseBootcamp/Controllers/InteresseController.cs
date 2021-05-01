using ArquivoBaseBootcamp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using SolucaoBaseBootcamp.Model;

namespace ArquivoBaseBootcamp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InteresseController : ControllerBase
    {
        private readonly IInteresseService _interesseService;

        public InteresseController(IInteresseService interesseService)
        {
            _interesseService = interesseService;
        }

        /// <summary>
        /// Este endpoint deve consultar as interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna a lista com todas as interessadas cadastradas
        /// </returns>
        [HttpGet]
        public IActionResult <List<Interesse>> ConsultarTodosInteresses()
        {
            return new string [] {"email"};
        }

        /// <summary>
        /// Este endpoint deve consultar a interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpGet]
        [Route("consultar/{email}")]
        public IActionResult ConsultarInteresse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Este endpoint deve realizar o inclusao de uma interessada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPost]
        [Route("incluir")]
        public IActionResult AdicionarInteresse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este endpoint deve atualizar os dados da interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPut]
        [Route("atualizar/{email}")]
        public IActionResult AtualizarInteresse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Este endpoint deve excluir a interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpDelete]
        [Route("excluir/{email}")]
        public IActionResult ExcluirInteresse()
        {
            throw new NotImplementedException();
        }
    }
}
