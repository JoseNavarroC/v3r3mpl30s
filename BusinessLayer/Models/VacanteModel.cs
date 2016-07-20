using System;


namespace BusinessLayer.Models
{
    public class VacanteModel
    {
        
        public int Id { get; set; }

        public string Puesto { get; set; }
        public string DescripcionPuesto { get; set; }
        public string PalabrasClave { get; set; }
        public string DireccionDelTrabajo { get; set; }
        public Boolean MostrarDireccion { get; set; }
        public Boolean RecibirCVEnPanel { get; set; }
        public string ReqExperienciaMinima { get; set; }
    }
}
