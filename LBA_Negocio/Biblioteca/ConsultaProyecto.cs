using LBA_Dominios.ModelosComandos;
using LBA_Infraestructura.Contratos;
using LBA_Negocio.Contratos;

namespace LBA_Negocio.Biblioteca
{
    public class ConsultaProyecto : IConsultaProyecto
    {
        private readonly IProyectoRepository _ProyectoRepository;
        public ConsultaProyecto(IProyectoRepository proyectoRepository)
        {
            _ProyectoRepository = proyectoRepository;
        }

        public async Task<string> IniciarSesion(InicioSesionDto inicioSesionDto)
        {
            string resultado = await _ProyectoRepository.IniciarSesion(inicioSesionDto);
            return resultado;
        }
        public async Task<string> VerSalon()
        {
            string resultado = await _ProyectoRepository.VerSalon();
            return resultado;
        }
        public async Task<string> VerRoles()
        {
            string resultado = await _ProyectoRepository.VerRoles();
            return resultado;
        }
        public async Task<string> VerMateria()
        {
            string resultado = await _ProyectoRepository.VerMateria();
            return resultado;
        }
        public async Task<string> VerEstudiantesMaterias()
        {
            string resultado = await _ProyectoRepository.VerEstudiantesMaterias();
            return resultado;
        }
        public async Task<string> VerProfesoresMaterias()
        {
            string resultado = await _ProyectoRepository.VerProfesoresMaterias();
            return resultado;
        }


    }
}
