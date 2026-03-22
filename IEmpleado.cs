namespace GestionInstitucion
{
    //  INTERFACE: IEmpleado
    //  Extiende IPersona con el contrato específico de
    //  cualquier empleado de la institución.
    public interface IEmpleado : IPersona
    {
        int AnioIncorporacion { get; set; }
    }
}
