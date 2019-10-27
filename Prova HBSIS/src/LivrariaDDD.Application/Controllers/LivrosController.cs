using System;
using System.Net;
using System.Threading.Tasks;
using Domain.Entities;
using LivrariaDDD.Domain.Interfaces.Services.Livros;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaDDD.Application.Controllers
{
    //pode adc mais rotas/ex/teste
    [Route("api/[controller]")] //http://localhost5000/api/Livros
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private ILivroService _livroService; // coloca-se _ para identificar variáveis privada
        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll () 
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }
            
            try
            {
                return Ok (await _livroService.GetAll()); //200 - ok
            }
            catch(ArgumentException ex) // trata erro de controller
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, ex.Message); // erro 50
            }
        }

        //localhost:5000/api/livros/123456789
        [HttpGet]
        [Route("{id}", Name = "GetWithId")] //Seleconar um registro //chama intrenamente na controler
        public async Task<ActionResult> Get (Guid id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }
            
            try
            {
                return Ok (await _livroService.Get(id)); //200 - ok // get da service
            }
            catch(ArgumentException ex) // trata erro de controller
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, ex.Message); // erro 50
            }
        }

       [HttpPost] //Inert
       public async  Task<ActionResult> Post ([FromBody] LivroEntity livro)
       {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var result = await _livroService.Post(livro);
                if(result != null){
                    return Created (new Uri (Url.Link("GetWithId", new {id = result.Id})), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch(ArgumentException ex) // trata erro de controller
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, ex.Message); // erro 50
            }
       }

       [HttpPut] //update
       public async  Task<ActionResult> Put ([FromBody] LivroEntity livro)
       {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }

            try
            {
                var result = await _livroService.Put(livro);
                if(result != null){
                    return Ok (result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch(ArgumentException ex) // trata erro de controller
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, ex.Message); // erro 50
            }
       }

       [HttpDelete ("{id}")]
        public async Task<ActionResult> Delete (Guid id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400 bad request - solicitação inválida
            }
            
            try
            {
                return Ok (await _livroService.Delete(id)); //200 - ok // get da service
            }
            catch(ArgumentException ex) // trata erro de controller
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, ex.Message); // erro 50
            }
        }
    }
}