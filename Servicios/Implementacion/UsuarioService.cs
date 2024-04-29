using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VistaSis.Models;
using VistaSis.Servicios.Contrato;


namespace VistaSis.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DbvitasysContext _dbContext;

        public UsuarioService(DbvitasysContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u => u.Correo == correo && u.Clave == clave)
                .FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}
