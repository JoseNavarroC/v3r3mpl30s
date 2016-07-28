using System;


namespace BusinessLayer.Models
{
    public class VacanteModel
    {
        
        public int IdVacante { get; set; }
        public int IdUsuario { get; set; }
        public string Puesto { get; set; }
        public string DescripcionPuesto { get; set; }
        public string PalabrasClave { get; set; }
        public string DireccionDelTrabajo { get; set; }
        public Boolean MostrarDireccion { get; set; }
        public Boolean RecibirCVEnPanel { get; set; }
        public int IdArea { get; set; }
        public int IdSubArea { get; set; }
        public int IdPais { get; set; }
        public int IdEstado { get; set; }
        public string ReqExperienciaMinima { get; set; }
        public string ReqEdadMinima { get; set; }
        public string ReqEdadMaxima { get; set; }
        public int ReqTipoEdad { get; set; }
        public int ReqGenero { get; set; }
        public Decimal ReqSalarioMinimo { get; set; }
        public Decimal ReqSalarioMaximo { get; set; }
        public int ReqSalarioTipoPago { get; set; }
        public int ReqSalarioForemaPago { get; set; }
        public Boolean ReqMostrarEnAviso { get; set; }
        public Boolean ReqSolicitarSalarioPostulan { get; set; }
        public string ReqTecnologia { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaFinPublicacion  { get; set; }
        public Boolean NotRecibirTodo { get; set; }
        public Boolean NotRecibirResumen { get; set; }
        public Boolean NotPrimerPostulante { get; set; }
        public Boolean NotDesactivarNotificaciones { get; set; }
        public int TipoPuesto { get; set; }
        public int IdIdioma { get; set; }
        public int IdNivelIdioma { get; set; }
        public int IdEduacion { get; set; }
        public int IdEstatusEducacion { get; set; }
        public Boolean Activa { get; set; }
        public int Vistas { get; set; }
        public int Actividad { get; set; }
        public int IdGeolocalizacion { get; set; }

    }
}
