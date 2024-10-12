﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "Email is required")] 
        public string? Email { get; init; }
        [Required(ErrorMessage = "Password name is required")] 
        public string? Password { get; init; }
    }
}
