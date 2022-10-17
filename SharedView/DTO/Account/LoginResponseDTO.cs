using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharedView.DTO.Account
{
    public class LoginResponseDTO
    {
        public string Value { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
