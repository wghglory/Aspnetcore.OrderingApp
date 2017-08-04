using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.OrderingApp.Models
{
    public class Client
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        [EmailAddress]
        [Remote("VerifyEmail", "Client")]   // must work with jquery-validation, when submitting form, check if email exists
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? ContactDate { get; set; }
        [Required]
        public string ClientType { get; set; }
        [Required]
        public string NearestLocation { get; set; }
        [Required]
        [MaxLength(25)]
        [DataType(DataType.MultilineText)]
        [UIHint("MultilineTextLarge")]  // UI hint, textarea when using EditorFor()
        public string Notes { get; set; }
        public List<EmailPromo> EmailPromos { get; set; }
        public Address BillingAddress { get; set; }
        public Address MailingAddress { get; set; }
    }
}