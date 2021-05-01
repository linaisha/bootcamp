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
            try{
                var interesse = _interesseService.ConsultarTodos();
                return Ok(interesse);
            }catch(InvalidCastException){
                return BadRequest(400);
            }
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
            try{
                var interesse = _interesseService.ConsultarPorEmail(email);
                return Ok(interesse);
            }catch(InvalidCastException){
                return BadRequest(400);
            }
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
        public IActionResult AdicionarInteresse(string email,[FromBody] string value)
        {
            try{
                var resposta = _interesseService.Incluir(email);
                return Ok(interesse);
            }catch(InvalidCastException){
                return BadRequest(400);
            }
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
            try{
                var resposta = _interesseService.AtualizarEmail(email);
                return Ok(interesse);
            }catch(InvalidCastException){
                return BadRequest(400);
            }
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
            try{
                var interesse = _interesseService.ExcluirPorEmail(email);
                return Ok(interesse);
            }catch(InvalidCastException){
                return BadRequest(400);
            }
        }
    }
}
