using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;
using LBA_Negocio.Contratos;

namespace LBA_Negocio.Fachada
{
    public class Fachada : IFachada
    {
        private readonly IConsultaProyecto _consultaProyecto;
        private readonly IComandosProyecto _comandosProyecto;

        public Fachada(IConsultaProyecto consultaProyecto, IComandosProyecto comandosProyecto)
        {
            _consultaProyecto = consultaProyecto;
            _comandosProyecto = comandosProyecto;
        }
        public Task<string> IniciarSesion(InicioSesionDto inicioSesionDto)
        {
            return _consultaProyecto.IniciarSesion(inicioSesionDto);
        }
       
        public Task<string> RegistrarUsuario(ComandoRegistroViewModel prospectivaViewModel)
        {
            return _comandosProyecto.RegistrarUsuario(prospectivaViewModel);
        }
        
        public Task<string> CrearSalon(Salon salon)
        {
            return _comandosProyecto.CrearSalon(salon);

        }
        public Task<string> CrearRol(Roles roles)
        {
            return _comandosProyecto.CrearRol(roles);

        } 
        public Task<string> CrearMateria(Materia materia)
        {
            return _comandosProyecto.CrearMateria(materia);

        }
        public Task<string> ActualizarSalon(Salon salon)
        {
            return _comandosProyecto.ActualizarSalon(salon);

        }
        public Task<string> ActualizarRoles(Roles roles)
        {
            return _comandosProyecto.ActualizarRoles(roles);

        } 
        public Task<string> ActualizarMateria(Materia materia)
        {
            return _comandosProyecto.ActualizarMateria(materia);

        }
        public Task<string> EliminarSalon(Salon salon)
        {
            return _comandosProyecto.EliminarSalon(salon);

        }
        public Task<string> EliminarRoles(Roles roles)
        {
            return _comandosProyecto.ActualizarRoles(roles);

        } 
        public Task<string> EliminarMateria(Materia materia)
        {
            return _comandosProyecto.EliminarMateria(materia);

        }
        public Task<string> VerSalon()
        {
            return _consultaProyecto.VerSalon();

        }
        public Task<string> VerRoles()
        {
            return _consultaProyecto.VerRoles();

        } 
        public Task<string> VerMateria()
        {
            return _consultaProyecto.VerMateria();

        } 
        public Task<string> VerEstudiantesMaterias()
        {
            return _consultaProyecto.VerEstudiantesMaterias();

        }
        public Task<string> VerProfesoresMaterias()
        {
            return _consultaProyecto.VerProfesoresMaterias();

        }

    }
}
