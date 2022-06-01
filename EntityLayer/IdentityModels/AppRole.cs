﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.IdentityModels
{
   public class AppRole:IdentityRole
    {
        [StringLength(500, ErrorMessage = "Role açıklaması en fazla 500 karakter olmalıdır!")]
        public string Description { get; set; }

    }
}
