using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;
using LBA_Negocio.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace LBA_Services_Delegade_Biblioteca.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ProyectoController : Controller
    {
        private readonly IFachada _fachada;
        delegate string delegadaConsultaAutores();
        delegate string delegadaRegistrarLibros(ComandoRegistroViewModel comandoRegistroViewModel);
        delegate string delegadaInicioSesionDto(InicioSesionDto inicioSesionDto);
        delegate string delegadaCrearSalon(Salon salon);
        delegate string delegadaCrearRol(Roles roles);
        delegate string delegadaCrearMateria(Materia materia);
        delegate string delegadaActualizarSalon(Salon salon);
        delegate string delegadaActualizarRoles(Roles roles);
        delegate string delegadaActualizarMateria(Materia materia);
        delegate string delegadaEliminarSalon(Salon salon);
        delegate string delegadaEliminarRoles(Roles roles);
        delegate string delegadaEliminarMateria(Materia materia);
        delegate string delegadaVerSalones();
        delegate string delegadaVerRoles();
        delegate string delegadaVerMateria();
        delegate string delegadaVerEstudiantesMaterias();
        delegate string delegadaVerProfesoresMaterias();

        public ProyectoController(IFachada fachada)
        {
            _fachada = fachada;
        }

        //[HttpGet("ConsultaAutores")]
        //public async Task<string> ConsultaAutores()
        //{
        //    delegadaConsultaAutores delegada = delegate ()
        //    {
        //        return _fachada.ConsultaAutores().Result;
        //    };
        //    return delegada();
        //}
        [HttpPost("RegistrarUsuario")]
        public async Task<string> RegistrarUsuario(ComandoRegistroViewModel comandoRegistroViewModel)
        {
            delegadaRegistrarLibros delegada = delegate (ComandoRegistroViewModel _comandoRegistroViewModel)
            {
                return _fachada.RegistrarUsuario(_comandoRegistroViewModel).Result;
            };
            return delegada(comandoRegistroViewModel);
        }

        [HttpPost("InicioSesionDto")]
        public async Task<string> IniciarSesion(InicioSesionDto inicioSesionDto)
        {
            delegadaInicioSesionDto delegada = delegate (InicioSesionDto _inicioSesionDto)
            {
                return _fachada.IniciarSesion(_inicioSesionDto).Result;
            };
            return delegada(inicioSesionDto);
        }

        [HttpPost("CrearSalon")]
        public async Task<string> CrearSalon(Salon salon)
        {
            delegadaCrearSalon delegada = delegate (Salon _salon)
            {
                return _fachada.CrearSalon(_salon).Result;
            };
            return delegada(salon);
        }
        [HttpPost("CrearRol")]
        public async Task<string> CrearRol(Roles roles)
        {
            delegadaCrearRol delegada = delegate (Roles _roles)
            {
                return _fachada.CrearRol(_roles).Result;
            };
            return delegada(roles);
        }
        [HttpPost("CrearMateria")]
        public async Task<string> CrearMateria(Materia materia)
        {
            delegadaCrearMateria delegada = delegate (Materia _materia)
            {
                return _fachada.CrearMateria(_materia).Result;
            };
            return delegada(materia);
        }
        [HttpPost("ActualizarSalon")]
        public async Task<string> ActualizarSalon(Salon salon)
        {
            delegadaActualizarSalon delegada = delegate (Salon _salon)
            {
                return _fachada.ActualizarSalon(_salon).Result;
            };
            return delegada(salon);
        }
        [HttpPost("ActualizarRoles")]
        public async Task<string> ActualizarRoles(Roles roles)
        {
            delegadaActualizarRoles delegada = delegate (Roles _roles)
            {
                return _fachada.ActualizarRoles(_roles).Result;
            };
            return delegada(roles);
        }
        [HttpPost("ActualizarMateria")]
        public async Task<string> ActualizarMateria(Materia materia)
        {
            delegadaActualizarMateria delegada = delegate (Materia _materia)
            {
                return _fachada.ActualizarMateria(_materia).Result;
            };
            return delegada(materia);
        }
        [HttpPost("EliminarSalon")]
        public async Task<string> EliminarSalon(Salon salon)
        {
            delegadaEliminarSalon delegada = delegate (Salon _salon)
            {
                return _fachada.EliminarSalon(_salon).Result;
            };
            return delegada(salon);
        }
        [HttpPost("EliminarRoles")]
        public async Task<string> EliminarRoles(Roles roles)
        {
            delegadaEliminarRoles delegada = delegate (Roles _roles)
            {
                return _fachada.EliminarRoles(_roles).Result;
            };
            return delegada(roles);
        }
        [HttpPost("EliminarMateria")]
        public async Task<string> EliminarMateria(Materia materia)
        {
            delegadaEliminarMateria delegada = delegate (Materia _materia)
            {
                return _fachada.EliminarMateria(_materia).Result;
            };
            return delegada(materia);
        }

        [HttpGet("VerSalones")]
        public async Task<string> VerSalon()
        {
            delegadaVerSalones delegada = delegate ()
            {
                return _fachada.VerSalon().Result;
            };
            return delegada();
        }
       
        [HttpGet("VerRoles")]
        public async Task<string> VerRoles()
        {
            delegadaVerRoles delegada = delegate ()
            {
                return _fachada.VerRoles().Result;
            };
            return delegada();
        }

        [HttpGet("VerMateria")]
        public async Task<string> VerMateria()
        {
            delegadaVerMateria delegada = delegate ()
            {
                return _fachada.VerMateria().Result;
            };
            return delegada();
        }
        [HttpGet("VerEstudiantesMaterias")]
        public async Task<string> VerEstudiantesMaterias()
        {
            delegadaVerEstudiantesMaterias delegada = delegate ()
            {
                return _fachada.VerEstudiantesMaterias().Result;
            };
            return delegada();
        }
        [HttpGet("VerProfesoresMaterias")]
        public async Task<string> VerProfesoresMaterias()
        {
            delegadaVerProfesoresMaterias delegada = delegate ()
            {
                return _fachada.VerProfesoresMaterias().Result;
            };
            return delegada();
        }

    }
}
