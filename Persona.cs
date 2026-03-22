namespace GestionInstitucion
{
    public enum EstadoCivil
    {
        Soltero,
        Casada,
        Casado,
        Divorciado,
        Viudo,
        UnionLibre
    }

    //  CLASE ABSTRACTA: Persona
    //  Implementa IPersona: provee los campos comunes y la
    //  implementación compartida de CambiarEstadoCivil().
    //  ObtenerRol() y MostrarInformacion() siguen siendo
    //  virtuales/abstractos para que las subclases los
    //  personalicen (POLIMORFISMO).
    public abstract class Persona : IPersona
    {
        public string      NumeroIdentificacion { get; private set; }
        public string      Nombre               { get; set; }
        public string      Apellidos            { get; set; }
        public EstadoCivil EstadoCivil          { get; private set; }
        public string      NombreCompleto       => $"{Nombre} {Apellidos}";

        protected Persona(string numeroId, string nombre, string apellidos, EstadoCivil estadoCivil)
        {
            NumeroIdentificacion = numeroId;
            Nombre               = nombre;
            Apellidos            = apellidos;
            EstadoCivil          = estadoCivil;
        }

        public abstract string ObtenerRol();

        public virtual string MostrarInformacion()
        {
            return $"ID: {NumeroIdentificacion} | Nombre: {NombreCompleto} | " +
                   $"Estado Civil: {EstadoCivil} | Rol: {ObtenerRol()}";
        }

        public void CambiarEstadoCivil(string numeroId, EstadoCivil nuevoEstado)
        {
            if (NumeroIdentificacion == numeroId)
            {
                EstadoCivil = nuevoEstado;
                Console.WriteLine($"✔ Estado civil de {NombreCompleto} actualizado a: {nuevoEstado}");
            }
            else
            {
                Console.WriteLine($"✘ ID {numeroId} no corresponde a esta persona.");
            }
        }
    }
}
