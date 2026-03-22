namespace GestionInstitucion
{
    //  CLASE ABSTRACTA: Empleado
    //  Hereda de Persona (que ya implementa IPersona) e
    //  implementa IEmpleado, agregando AnioIncorporacion.
    public abstract class Empleado : Persona, IEmpleado
    {
        public int AnioIncorporacion { get; set; }

        protected Empleado(string numeroId, string nombre, string apellidos,
                           EstadoCivil estadoCivil, int anioIncorporacion)
            : base(numeroId, nombre, apellidos, estadoCivil)
        {
            AnioIncorporacion = anioIncorporacion;
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $" | Incorporación: {AnioIncorporacion}";
        }
    }
}
