using System.ComponentModel.DataAnnotations;

namespace LBA_Dominios.ModelosComandos
{
    public class ComandoRegistroViewModel
    {
        public string? nombreLogin { get; set; }
        public string? contrasena { get; set; }
        [Required]
        public int? idRol { get; set; }
        public string? usuarioCreacion { get; set; }
        public string? nombres { get; set; }
        public string? apellidos { get; set; }
        public string? tipoIdentificacion { get; set; }
        public int? numeroIdentificacion { get; set; }

    }

    public class Salon
    {
        public int idSalon { get; set; }
        public string nombreSalon { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }


    }
    public class Roles
    {
        public int idRoles{ get; set; }
        public string nombreRol { get; set; }
        public string usuarioCrea { get; set; }
        public string usuarioModifica { get; set; }

    }
    public class Materia
    {
        public int idMateria { get; set; }
        public string nombreMateria { get; set; }
        public string usuarioCrea { get; set; }
        public int horasClase { get; set; }
        public string usuarioModifica { get; set; }


    }
}
