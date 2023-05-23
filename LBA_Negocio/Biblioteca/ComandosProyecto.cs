using LBA_Dominios.ModelosComandos;
using LBA_Infraestructura.Contratos;
using LBA_Negocio.Contratos;

namespace LBA_Negocio.Biblioteca
{
    public class ComandosProyecto : IComandosProyecto
    {
        private readonly IProyectoRepository _ProyectoRepository;
        public ComandosProyecto(IProyectoRepository proyectoRepository)
        {
            _ProyectoRepository = proyectoRepository;
        }
        public async Task<string> RegistrarUsuario(ComandoRegistroViewModel comandoRegistroViewModel)
        {
            string resultado = await _ProyectoRepository.RegistrarUsuario(comandoRegistroViewModel);
            return resultado;
        } 

        public async Task<string> CrearSalon(Salon salon)
        {
            string resultado = await _ProyectoRepository.CrearSalon(salon);
            return resultado;

        }
        public async Task<string> CrearRol(Roles roles)
        {
            string resultado = await _ProyectoRepository.CrearRol(roles);
            return resultado;

        }
        public async Task<string> CrearMateria(Materia materia)
        {
            string resultado = await _ProyectoRepository.CrearMateria(materia);
            return resultado;

        }
        public async Task<string> ActualizarSalon(Salon salon)
        {
            string resultado = await _ProyectoRepository.ActualizarSalon(salon);
            return resultado;

        }
        public async Task<string> ActualizarRoles(Roles roles)
        {
            string resultado = await _ProyectoRepository.ActualizarRoles(roles);
            return resultado;

        }
        public async Task<string> ActualizarMateria(Materia materia)
        {
            string resultado = await _ProyectoRepository.ActualizarMateria(materia);
            return resultado;

        }
        public async Task<string> EliminarSalon(Salon salon)
        {
            string resultado = await _ProyectoRepository.EliminarSalon(salon);
            return resultado;

        }
        public async Task<string> EliminarRoles(Roles roles)
        {
            string resultado = await _ProyectoRepository.EliminarRoles(roles);
            return resultado;

        }
        public async Task<string> EliminarMateria(Materia materia)
        {
            string resultado = await _ProyectoRepository.EliminarMateria(materia);
            return resultado;

        }



    }
}
