using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaTarefas.Models;
using SistemaTarefas.Repositorios.Interfaces;

namespace SistemaTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<MUsuario>>> BuscarTodosUsuarios()
        {
            List<MUsuario> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MUsuario>> BuscarPorId(int id)
        {
            MUsuario usuario = await _usuarioRepositorio.BuscarPorId(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<MUsuario>> Cadastrar([FromBody] MUsuario usuarioModel)
        {
            MUsuario usuario = await _usuarioRepositorio.Adicionar(usuarioModel);

            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MUsuario>> Atualizar([FromBody] MUsuario usuarioModel, int id)
        {
            usuarioModel.Id = id;
            MUsuario usuario = await _usuarioRepositorio.Atualizar(usuarioModel, id);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MUsuario>> Apagar(int id)
        {
            bool apagado = await _usuarioRepositorio.Apagar(id);

            return Ok(apagado);
        }
    }
}
