using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedView.DTO.Account
{
    public class RegisterRequestDTO
    {
        [Required(ErrorMessage = "Name should not be empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password should not be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
