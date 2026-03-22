namespace GestionInstitucion
{
    //  CLASE: Estudiante
    //  Hereda de Persona e implementa IEstudiante.
    public class Estudiante : Persona, IEstudiante
    {
        public string Curso { get; private set; }

        public Estudiante(string numeroId, string nombre, string apellidos,
                          EstadoCivil estadoCivil, string curso)
            : base(numeroId, nombre, apellidos, estadoCivil)
        {
            Curso = curso;
        }

        public override string ObtenerRol() => "Estudiante";

        public override string MostrarInformacion()
            => base.MostrarInformacion() + $" | Curso: {Curso}";

        public void MatricularNuevoCurso(string numeroId, string nuevoCurso)
        {
            if (NumeroIdentificacion == numeroId)
            {
                string anterior = Curso;
                Curso = nuevoCurso;
                Console.WriteLine($"✔ {NombreCompleto} matriculado: '{anterior}' → '{nuevoCurso}'");
            }
            else
                Console.WriteLine($"✘ ID {numeroId} no corresponde a este estudiante.");
        }
    }

    //  CLASE: Profesor
    //  Hereda de Empleado e implementa IProfesor.
    public class Profesor : Empleado, IProfesor
    {
        public string Facultad { get; private set; }

        public Profesor(string numeroId, string nombre, string apellidos,
                        EstadoCivil estadoCivil, int anioIncorporacion, string facultad)
            : base(numeroId, nombre, apellidos, estadoCivil, anioIncorporacion)
        {
            Facultad = facultad;
        }

        public override string ObtenerRol() => "Profesor";

        public override string MostrarInformacion()
            => base.MostrarInformacion() + $" | Facultad: {Facultad}";

        public void CambiarFacultad(string numeroId, string nuevaFacultad)
        {
            if (NumeroIdentificacion == numeroId)
            {
                string anterior = Facultad;
                Facultad = nuevaFacultad;
                Console.WriteLine($"✔ {NombreCompleto}: facultad '{anterior}' → '{nuevaFacultad}'");
            }
            else
                Console.WriteLine($"✘ ID {numeroId} no corresponde a este profesor.");
        }
    }

    //  CLASE: Administrativo
    //  Hereda de Empleado e implementa IAdministrativo.
    public class Administrativo : Empleado, IAdministrativo
    {
        public string Dependencia { get; private set; }

        public Administrativo(string numeroId, string nombre, string apellidos,
                              EstadoCivil estadoCivil, int anioIncorporacion, string dependencia)
            : base(numeroId, nombre, apellidos, estadoCivil, anioIncorporacion)
        {
            Dependencia = dependencia;
        }

        public override string ObtenerRol() => "Administrativo";

        public override string MostrarInformacion()
            => base.MostrarInformacion() + $" | Dependencia: {Dependencia}";

        public void ModificarDependencia(string numeroId, string nuevaDependencia)
        {
            if (NumeroIdentificacion == numeroId)
            {
                string anterior = Dependencia;
                Dependencia = nuevaDependencia;
                Console.WriteLine($"✔ {NombreCompleto}: dependencia '{anterior}' → '{nuevaDependencia}'");
            }
            else
                Console.WriteLine($"✘ ID {numeroId} no corresponde a este administrativo.");
        }
    }

    //  CLASE: ServiciosVarios
    //  Hereda de Empleado e implementa IServiciosVarios.
    public class ServiciosVarios : Empleado, IServiciosVarios
    {
        public string LaborEspecifica { get; private set; }

        public ServiciosVarios(string numeroId, string nombre, string apellidos,
                               EstadoCivil estadoCivil, int anioIncorporacion, string labor)
            : base(numeroId, nombre, apellidos, estadoCivil, anioIncorporacion)
        {
            LaborEspecifica = labor;
        }

        public override string ObtenerRol() => "Servicios Varios";

        public override string MostrarInformacion()
            => base.MostrarInformacion() + $" | Labor: {LaborEspecifica}";

        public void ModificarLabor(string numeroId, string nuevaLabor)
        {
            if (NumeroIdentificacion == numeroId)
            {
                string anterior = LaborEspecifica;
                LaborEspecifica = nuevaLabor;
                Console.WriteLine($"✔ {NombreCompleto}: labor '{anterior}' → '{nuevaLabor}'");
            }
            else
                Console.WriteLine($"✘ ID {numeroId} no corresponde a este empleado de servicios.");
        }
    }
}
