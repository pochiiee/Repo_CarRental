﻿using System.ComponentModel.DataAnnotations;


namespace CarRental.Models.Entites
{
    public class ContactMessage
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime DateSubmitted { get; set; } = DateTime.Now;

    }
}
