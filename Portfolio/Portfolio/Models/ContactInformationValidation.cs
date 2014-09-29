using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    [MetadataType(typeof(ContactInformationValidation))]
    public partial class ContactInformation
    {
    }

    public class ContactInformationValidation
    {
        [Required, MaxLength(200)]
        public string FirstName { get; set; }
        [Required, MaxLength(200)]
        public string LastName { get; set; }
        [Required, MaxLength(200)]
        public string Email { get; set; }
        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}