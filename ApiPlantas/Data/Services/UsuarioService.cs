using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using ApiPlantas.Data.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace ApiPlantas.Data.Services
{
	public class UsuarioService
	{
		//agregar usuarios a la bd
		private AppDbContext _context;
		public UsuarioService(AppDbContext context)
		{
			_context = context;
		}

		public void AddUsuarios(UsuarioVM usuario)
		{
			var _usuario = new Usuario()
			{
				NombreUsuario = usuario.NombreUsuario,
				Correo = usuario.Correo,
				NumTelefono = usuario.NumTelefono,
			};
			_context.Usuarios.Add(_usuario);
			_context.SaveChanges();
		}
	}
}
