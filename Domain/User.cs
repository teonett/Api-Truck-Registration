using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruckRegistration.Domain
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(30)]
        [MaxLength(30, ErrorMessage = "Este campo deve conter entre 3 e 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 30 caracteres.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(30)]
        [MaxLength(30, ErrorMessage = "Este campo deve conter entre 7 e 30 caracteres.")]
        [MinLength(7, ErrorMessage = "Este campo deve conter entre 7 e 30 caracteres.")]
        public string Password { get; set; }

        public string Role {get; set;}
    }
}