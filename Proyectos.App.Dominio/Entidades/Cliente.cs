using System;
using System.ComponentModel.DataAnnotations;

namespace Proyectos.App.Dominio.Entidades

{
    public class Cliente
    {
        [Display(Name="ID")]
        public int id {get;set;}
        [Required]
        [Display(Name="Nombres")]
        public string nombre {get;set;}
        [Required]
        [Display(Name="Apellidos")]
        public string apellido {get;set;}
        [Required]
        [Display(Name="Tipo de documento")]
        public string tipoDocumento {get;set;}
        [Required]
        [Display(Name="Numero de documento")]
        public int numeroDocumento {get;set;}
        [Required]
        [Display(Name="RH")]
        public string rh {get;set;}
        [Required]
        [Display(Name="Motivo de cita")]
        public string motivoCita {get;set;}
        [Display(Name="Observaciones del doctor")]
        public string observaciones {get;set;}

    }
}