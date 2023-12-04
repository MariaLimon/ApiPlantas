using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlantas.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		public UsuarioService _usuarioService;

		public UsuarioController(UsuarioService usuarioService)
		{
			_usuarioService = usuarioService;
		}

		[HttpPost("add-users")]
		public IActionResult AddUsuario([FromBody]UsuarioVM usuario)
		{
			_usuarioService.AddUsuarios(usuario);
			return Ok();
		}
	}
}
