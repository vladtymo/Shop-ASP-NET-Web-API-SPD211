﻿namespace ShopApi_SPD211.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
