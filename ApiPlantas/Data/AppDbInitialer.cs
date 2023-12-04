using System;
using System.Linq;
using ApiPlantas.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ApiPlantas.Data
{
	public class AppDbInitialer
	{
		//metoso para agregar a la base de datos 
		public static void Seed(IApplicationBuilder aplicationBuilder)
		{
			using (var serviceScope = aplicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
				if(!context.Usuarios.Any())
				{
					context.Usuarios.AddRange(new Usuario()
					{
						NombreUsuario = "nombre",
						Correo = "correo",
						NumTelefono = 1529
					},
					new Usuario()
					{
						NombreUsuario = "nombre35",
						Correo = "correo54",
						NumTelefono = 152945
					}) ;
					context.SaveChanges();
				}
			}
		}
	}
}
