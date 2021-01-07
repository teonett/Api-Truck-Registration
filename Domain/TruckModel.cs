using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruckRegistration.Domain
{
    [Table("TruckModel")]
    public class TruckModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(10)]
        [MaxLength(10, ErrorMessage = "Este campo deve conter entre 2 e 10 caracteres.")]
        [MinLength(2, ErrorMessage = "Este campo deve conter entre 2 e 10 caracteres.")]
        public string Name { get; set; }
    }
}