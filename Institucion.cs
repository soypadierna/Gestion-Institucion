namespace GestionInstitucion
{
    //  CLASE: Institucion
    //  La lista interna usa IPersona — no la clase concreta.
    //  Así el código depende del CONTRATO, no de la implementación.
    //  Los métodos de búsqueda devuelven las interfaces específicas
    //  (IEstudiante, IProfesor, etc.) para acceder solo a lo que
    //  cada contrato garantiza.
    public class Institucion
    {
        // Lista tipada con la INTERFACE, no con la clase abstracta
        private readonly List<IPersona> _personas = new();
        public string Nombre { get; }

        public Institucion(string nombre) => Nombre = nombre;

        public void Agregar(IPersona p)
        {
            if (_personas.Any(x => x.NumeroIdentificacion == p.NumeroIdentificacion))
            {
                Console.WriteLine($"⚠ Ya existe una persona con ID {p.NumeroIdentificacion}.");
                return;
            }
            _personas.Add(p);
            Console.WriteLine($"✔ Registrado: {p.NombreCompleto} ({p.ObtenerRol()})");
        }

        public IPersona? BuscarPorId(string id) =>
            _personas.FirstOrDefault(p => p.NumeroIdentificacion == id);

        public void ListarTodos()
        {
            Console.WriteLine($"\n{"─",50}");
            Console.WriteLine($"  INSTITUCIÓN: {Nombre}  ({_personas.Count} registros)");
            Console.WriteLine($"{"─",50}");
            foreach (IPersona p in _personas)
                Console.WriteLine("  " + p.MostrarInformacion());
            Console.WriteLine($"{"─",50}\n");
        }

        public void ListarPorRol(string rol)
        {
            var filtro = _personas.Where(p => p.ObtenerRol() == rol).ToList();
            Console.WriteLine($"\n── {rol}s ({filtro.Count}) ──");
            foreach (IPersona p in filtro)
                Console.WriteLine("  " + p.MostrarInformacion());
        }

        //  MÉTODOS DE MODIFICACIÓN — usan las interfaces
        //  específicas con 'is' para hacer el cast seguro
        public void CambiarEstadoCivil(string id, EstadoCivil nuevo)
        {
            IPersona? p = BuscarPorId(id);
            if (p == null) { Console.WriteLine($"✘ No se encontró persona con ID {id}."); return; }
            p.CambiarEstadoCivil(id, nuevo);
        }

        public void MatricularEstudiante(string id, string nuevoCurso)
        {
            if (BuscarPorId(id) is IEstudiante est)
                est.MatricularNuevoCurso(id, nuevoCurso);
            else
                Console.WriteLine($"✘ No se encontró un Estudiante con ID {id}.");
        }

        public void CambiarFacultadProfesor(string id, string nuevaFacultad)
        {
            if (BuscarPorId(id) is IProfesor prof)
                prof.CambiarFacultad(id, nuevaFacultad);
            else
                Console.WriteLine($"✘ No se encontró un Profesor con ID {id}.");
        }

        public void ModificarLaborServicio(string id, string nuevaLabor)
        {
            if (BuscarPorId(id) is IServiciosVarios sv)
                sv.ModificarLabor(id, nuevaLabor);
            else
                Console.WriteLine($"✘ No se encontró personal de Servicios Varios con ID {id}.");
        }

        public void ModificarDependenciaAdministrativo(string id, string nuevaDep)
        {
            if (BuscarPorId(id) is IAdministrativo adm)
                adm.ModificarDependencia(id, nuevaDep);
            else
                Console.WriteLine($"✘ No se encontró un Administrativo con ID {id}.");
        }
    }
}
