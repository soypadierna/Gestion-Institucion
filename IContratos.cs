namespace GestionInstitucion
{
    //  INTERFACE: IEstudiante
    //  Contrato específico para estudiantes.
    public interface IEstudiante : IPersona
    {
        string Curso { get; }
        void MatricularNuevoCurso(string numeroId, string nuevoCurso);
    }

    //  INTERFACE: IProfesor
    //  Contrato específico para profesores.
    public interface IProfesor : IEmpleado
    {
        string Facultad { get; }
        void CambiarFacultad(string numeroId, string nuevaFacultad);
    }

    //  INTERFACE: IAdministrativo
    //  Contrato específico para personal administrativo.
    public interface IAdministrativo : IEmpleado
    {
        string Dependencia { get; }
        void ModificarDependencia(string numeroId, string nuevaDependencia);
    }

    //  INTERFACE: IServiciosVarios
    //  Contrato específico para personal de servicios.
    public interface IServiciosVarios : IEmpleado
    {
        string LaborEspecifica { get; }
        void ModificarLabor(string numeroId, string nuevaLabor);
    }
}
