using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DND.IDP.Controllers.Account
{
    public class AdditionalAuthenticationFactorViewModel
    {
        [Required]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberLogin { get; set; }
    }

}
