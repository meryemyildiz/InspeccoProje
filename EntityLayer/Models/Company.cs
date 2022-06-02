using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Models
{
   public class Company:Base<int>
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Şirket adı en az 2, en fazla 50 karakter olmalıdır!")]
        public string CompanyName { get; set; }
    }
}
