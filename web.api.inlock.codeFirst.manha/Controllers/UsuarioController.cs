using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web.api.inlock.codeFirst.manha.Domains;
using web.api.inlock.codeFirst.manha.Interfaces;
using web.api.inlock.codeFirst.manha.Repositories;

namespace web.api.inlock.codeFirst.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        //********************************************** CADASTRAR USUARIO COM HASH ********************************
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
