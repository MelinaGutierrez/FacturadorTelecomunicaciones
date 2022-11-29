using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaTelecomunicaciones.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo Ci es obligatorio.")]
        public string Ci { get; set; }

        [Required(ErrorMessage = "El campo telefono es obligatorio.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo correo electronico es obligatorio.")]
        [EmailAddress(ErrorMessage ="El campo correo electronico no es una direciion de correo valida.")]
        public string Email { get; set; }

        [Display(Name ="Contraseña")]
        [Required(ErrorMessage ="El campo contraseña es obligatorio")]
        [StringLength(100,ErrorMessage ="El numero de caracteres de {0} debe ser al menos {2}.",MinimumLength = 6)]

        public string Password { get; set; }
    }
}
