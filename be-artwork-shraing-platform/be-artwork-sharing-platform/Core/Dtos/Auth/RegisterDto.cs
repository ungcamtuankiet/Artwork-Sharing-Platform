﻿using System.ComponentModel.DataAnnotations;

namespace be_artwork_sharing_platform.Core.Dtos.Auth
{
    public class RegisterDto
    {
        public string FullName { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
    }
}