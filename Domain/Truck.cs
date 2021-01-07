using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruckRegistration.Domain
{
    [Table("Truck")]
    public class Truck
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(60)]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DataType(DataType.Date)]
        //[MaxLength(4)]
        //[MinLength(4)]
        //[Range(DateTime.Now, DateTime.Now.Year)]
        public DateTime YearManufacturing {get;set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DataType(DataType.Date)]
        //[MaxLength(4)]
        //[MinLength(4)]
        //[Range(DateTime.Now.Year, 9999)]
        public DateTime YearModel { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        //[Range(1, int.MaxValue, ErrorMessage = "Modelo de caminhão inválido")]
        public int TruckModelId { get; set; }

        public virtual TruckModel TruckModel { get; set; }
    }
}