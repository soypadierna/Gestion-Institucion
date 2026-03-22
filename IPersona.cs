namespace GestionInstitucion
{
    //  INTERFACE: IPersona
    //  Define el CONTRATO que toda persona debe cumplir.
    //  No tiene implementación ni campos — solo firmas.
    public interface IPersona
    {
        string NumeroIdentificacion { get; }
        string Nombre               { get; set; }
        string Apellidos            { get; set; }
        EstadoCivil EstadoCivil     { get; }
        string NombreCompleto       { get; }

        string ObtenerRol();
        string MostrarInformacion();
        void   CambiarEstadoCivil(string numeroId, EstadoCivil nuevoEstado);
    }
}
