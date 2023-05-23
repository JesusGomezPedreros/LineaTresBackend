using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;
using LBA_Infraestructura.Contratos;
using NpgsqlTypes;
using System.Data;
using System.Data.SqlClient;

namespace LBA_Infraestructura.Repositorios
{
    public class ProyectoRepository : Repository, IProyectoRepository
    {
        private SqlCommand _comandogeneral;
        public ProyectoRepository()
        {
            _comandogeneral = new SqlCommand();
        }
        //que inserta valores en las tablas autores, editoriales, libros y autores_has_libros
        public async Task<string> RegistrarUsuario(ComandoRegistroViewModel comandoRegistroViewModel)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@NombreLogin", SqlDbType.VarChar).Value = comandoRegistroViewModel.nombreLogin;
            _comandogeneral.Parameters.AddWithValue("@Contrasena", SqlDbType.VarChar).Value = comandoRegistroViewModel.contrasena;
            _comandogeneral.Parameters.AddWithValue("@IDRol", SqlDbType.Int).Value = comandoRegistroViewModel.idRol;
            _comandogeneral.Parameters.AddWithValue("@UsuarioCreador", SqlDbType.VarChar).Value = comandoRegistroViewModel.usuarioCreacion;
            _comandogeneral.Parameters.AddWithValue("@Nombres", SqlDbType.VarChar).Value = comandoRegistroViewModel.nombres;
            _comandogeneral.Parameters.AddWithValue("@Apellidos", SqlDbType.VarChar).Value = comandoRegistroViewModel.apellidos;
            _comandogeneral.Parameters.AddWithValue("@TipoIdentificacion", SqlDbType.VarChar).Value = comandoRegistroViewModel.tipoIdentificacion;
            _comandogeneral.Parameters.AddWithValue("@NumeroIdentificacion", SqlDbType.Int).Value = comandoRegistroViewModel.numeroIdentificacion;
            _comandogeneral.Parameters.Add("@Usuario", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output; // Agregar el parámetro de salida
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_REGISTRAR_USUARIO");
            // Leer el valor del parámetro de salida
            var usuario = _comandogeneral.Parameters["@Usuario"].Value.ToString();
            if (!string.IsNullOrEmpty(usuario))
            {
                // Usuario creado exitosamente
                return resultado;
            }
            else
            {
                // Error al crear el usuario
                return "El usuario ya existe";
            }
        }

        public async Task<string> IniciarSesion(InicioSesionDto inicioSesionDto)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@NombreLogin", SqlDbType.VarChar).Value = inicioSesionDto.correo;
            _comandogeneral.Parameters.AddWithValue("@Contrasena", SqlDbType.VarChar).Value = inicioSesionDto.password;
            _comandogeneral.Parameters.Add("@UsuarioValido", SqlDbType.Bit).Direction = ParameterDirection.Output;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_LOGIN");
            // Leer el valor del parámetro de salida
            var usuarioValido = (bool)_comandogeneral.Parameters["@UsuarioValido"].Value;
            if (usuarioValido)
            {
                // Usuario válido
                return resultado;
            }
            else
            {
                // Usuario no válido
                return "El login no existe";
            }
        }

        public async Task<string> CrearSalon(Salon salon)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@NombreSalon", SqlDbType.VarChar).Value = salon.nombreSalon;
            _comandogeneral.Parameters.AddWithValue("@usuarioCrea", SqlDbType.VarChar).Value = salon.usuarioCrea;
            _comandogeneral.Parameters.Add("@IDSalon", SqlDbType.Bit).Direction = ParameterDirection.Output;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_CREAR_SALON");
            // Leer el valor del parámetro de salida
            var idSalon = (bool)_comandogeneral.Parameters["@IDSalon"].Value;
            if (idSalon)
            {
                // Usuario válido
                return resultado;
            }
            else
            {
                // Usuario no válido
                return "El salon no existe";
            }
        }
        public async Task<string> CrearRol(Roles roles)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@NombreRol", SqlDbType.VarChar).Value = roles.nombreRol;
            _comandogeneral.Parameters.AddWithValue("@usuarioCrea", SqlDbType.VarChar).Value = roles.usuarioCrea;
            _comandogeneral.Parameters.Add("@IDRol", SqlDbType.Bit).Direction = ParameterDirection.Output;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_CREAR_ROL");
            // Leer el valor del parámetro de salida
            var IDRol = (bool)_comandogeneral.Parameters["@IDRol"].Value;
            if (IDRol)
            {
                // Usuario válido
                return resultado;
            }
            else
            {
                // Usuario no válido
                return "El roll no existe";
            }
        }
        public async Task<string> CrearMateria(Materia materia)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@NombreMateria", SqlDbType.VarChar).Value = materia.nombreMateria;
            _comandogeneral.Parameters.AddWithValue("@usuarioCrea", SqlDbType.VarChar).Value = materia.usuarioCrea;
            _comandogeneral.Parameters.AddWithValue("@HorasMateria", SqlDbType.Int).Value = materia.horasClase;
            _comandogeneral.Parameters.Add("@IDMateria", SqlDbType.Bit).Direction = ParameterDirection.Output;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_CREAR_MATERIA");
            // Leer el valor del parámetro de salida
            var IDMateria = (bool)_comandogeneral.Parameters["@IDMateria"].Value;
            if (IDMateria)
            {
                // Usuario válido
                return resultado;
            }
            else
            {
                // Usuario no válido
                return "El roll no existe";
            }
        }
        public async Task<string> ActualizarSalon(Salon salon)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IDSalon", SqlDbType.Int).Value = salon.idSalon;
            _comandogeneral.Parameters.AddWithValue("@usuarioModifica", SqlDbType.VarChar).Value = salon.usuarioModifica;
            _comandogeneral.Parameters.AddWithValue("@NombreSalon", SqlDbType.VarChar).Value = salon.nombreSalon;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_ACTUALIZAR_SALON");
            return resultado;
        }
        public async Task<string> ActualizarRoles(Roles roles)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IDRol", SqlDbType.Int).Value = roles.idRoles;
            _comandogeneral.Parameters.AddWithValue("@NombreRol", SqlDbType.VarChar).Value = roles.nombreRol;
            _comandogeneral.Parameters.AddWithValue("@usuarioModifica", SqlDbType.VarChar).Value = roles.usuarioModifica;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_ACTUALIZAR_ROL");
            return resultado;

        }
        public async Task<string> ActualizarMateria(Materia materia)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IDMateria", SqlDbType.Int).Value = materia.idMateria;
            _comandogeneral.Parameters.AddWithValue("@NombreMateria", SqlDbType.VarChar).Value = materia.nombreMateria;
            _comandogeneral.Parameters.AddWithValue("@usuarioModifica", SqlDbType.VarChar).Value = materia.usuarioModifica;
            _comandogeneral.Parameters.AddWithValue("@HorasMateria", SqlDbType.Int).Value = materia.horasClase;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_CREAR_MATERIA");
            return resultado;

        }
        public async Task<string> EliminarSalon(Salon salon)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IDSalon", SqlDbType.Int).Value = salon.idSalon;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_ELIMINAR_SALON");
            return resultado;
        }
        public async Task<string> EliminarRoles(Roles roles)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IDRol", SqlDbType.Int).Value = roles.idRoles;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_ELIMINAR_ROL");
            return resultado;

        }
        public async Task<string> EliminarMateria(Materia materia)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IDMateria", SqlDbType.Int).Value = materia.idMateria;
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_ELIMINAR_MATERIA");
            return resultado;

        }
        public async Task<string> VerSalon()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_VER_SALONES");
            return resultado;
        }
        public async Task<string> VerRoles()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_VER_ROLES");
            return resultado;

        }
        public async Task<string> VerMateria()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "SP_VER_MATERIAS");
            return resultado;

        } 
        
        public async Task<string> VerEstudiantesMaterias()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "ListarEstudiantesConMateria");
            return resultado;

        } 
        public async Task<string> VerProfesoresMaterias()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "ListarProfesoresConMateria");
            return resultado;

        }
    }
}
