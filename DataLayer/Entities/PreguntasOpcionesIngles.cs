//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PreguntasOpcionesIngles
    {
        public int Id { get; set; }
        public int IdPregunta { get; set; }
        public string Opcion { get; set; }
        public bool Correcta { get; set; }
    
        public virtual PreguntasIngles PreguntasIngles { get; set; }
    }
}