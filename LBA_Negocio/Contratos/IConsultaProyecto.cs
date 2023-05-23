using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;

namespace LBA_Negocio.Contratos
{
    public interface IConsultaProyecto
    {
       
        Task<string> IniciarSesion(InicioSesionDto inicioSesionDto);
        Task<string> VerSalon();
        Task<string> VerRoles();
        Task<string> VerMateria();
        Task<string> VerEstudiantesMaterias();
        Task<string> VerProfesoresMaterias();
    }

}

