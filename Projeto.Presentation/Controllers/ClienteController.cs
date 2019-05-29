using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.ViewModels;

namespace Projeto.Presentation.Controllers
{
    [Route("application/json")]
    [Produces("api/Cliente")]
    public class ClienteController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody] ClienteCadastroViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestResult();
            }

            try
            {
                return Ok($"Cliente '{model.Nome}' cadastrado com sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] ClienteEdicaoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestResult();
            }
            try
            {
                return Ok($"Cliente '{model.Nome}' atualizado com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{idCliente}")]
        public IActionResult Delete(int idCliente)
        {
            try
            {
                return Ok($"Cliente excluído com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);

            }
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        [HttpGet("{idCliente}")]

        public IActionResult GetById(int idCliente)
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }


    }
}