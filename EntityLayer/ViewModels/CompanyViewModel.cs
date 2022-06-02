using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.ViewModels
{
   public class CompanyViewModel
    {
       
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Şirket adı en az 2, en fazla 50 karakter olmalıdır!")]
        public string CompanyName { get; set; }
    }
}
