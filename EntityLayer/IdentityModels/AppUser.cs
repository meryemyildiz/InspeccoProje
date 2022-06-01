using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.IdentityModels
{
    [Index(nameof(TcNumber), IsUnique = true)]
    public class AppUser:IdentityUser
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsim en az 2 en çok 50 karakter olmalıdır!")]
        [Required(ErrorMessage = "İsim alanı gereklidir")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsim en az 2 en çok 50 karakter olmalıdır!")]
        [Required(ErrorMessage = "Soyisim alanı gereklidir")]
        public string Surname { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik Numarası 11 Karakter Olmalıdır!")]
        [Required(ErrorMessage = "TC kimlik gereklidir")]

        public string TcNumber { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
      
      
    }
}
