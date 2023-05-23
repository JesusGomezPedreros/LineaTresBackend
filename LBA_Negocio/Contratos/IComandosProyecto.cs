using LBA_Dominios.ModelosComandos;

namespace LBA_Negocio.Contratos
{
    public interface IComandosProyecto
    {
        Task<string> RegistrarUsuario(ComandoRegistroViewModel comandoRegistroViewModel);
        Task<string> CrearSalon(Salon salon);
        Task<string> CrearRol(Roles roles);
        Task<string> CrearMateria(Materia materia);
        Task<string> ActualizarSalon(Salon salon);
        Task<string> ActualizarRoles(Roles roles);
        Task<string> ActualizarMateria(Materia materia);
        Task<string> EliminarSalon(Salon salon);
        Task<string> EliminarRoles(Roles roles);
        Task<string> EliminarMateria(Materia materia);


    }
}
