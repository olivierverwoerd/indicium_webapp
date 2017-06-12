﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using indicium_webapp.Models.InterfaceItemModels;

namespace indicium_webapp.Models.AccountViewModels
{
    public class ApplicationUserViewModel
    {
        public ApplicationUserViewModel()
        {
            Roles = new HashSet<CheckBoxListItem>();
        }
        
        public string Id { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Voornaam mag maximaal 50 karakters zijn.")]
        [DataType(DataType.Text)]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Achternaam mag maximaal 100 karakters zijn.")]
        [DataType(DataType.Text)]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        
        [EmailAddress]
        [Display(Name = "E-mailadres")]
        public string Email { get; set; }

        [Required]
        [StringLength(1)]
        [DataType(DataType.Text)]
        [Display(Name = "Geslacht")]
        public string Sex { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Geboortedatum is ongeldig.")]
        [DataType(DataType.Date)]
        [Display(Name = "Geboortedatum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public string Birthday { get; set; }

        [StringLength(100, ErrorMessage = "Straat is ongeldig.")]
        [DataType(DataType.Text)]
        [Display(Name = "Straat")]
        public string AddressStreet { get; set; }

        [StringLength(5, ErrorMessage = "Huisnummer is ongeldig.")]
        [DataType(DataType.Text)]
        [Display(Name = "Huisnummer")]
        public string AddressNumber { get; set; }

        [StringLength(7, ErrorMessage = "Postcode is ongeldig.")]
        [DataType(DataType.Text)]
        [Display(Name = "Postcode")]
        public string AddressPostalCode { get; set; }

        [StringLength(100, ErrorMessage = "Woonplaats is ongeldig.")]
        [Display(Name = "Woonplaats")]
        public string AddressCity { get; set; }

        [Display(Name = "Land")]
        public string AddressCountry { get; set; }

        [RegularExpression(@"^(NL([0-9]{2})([A-Z]{4})([0-9]{10}))$", ErrorMessage = "Ongeldige ingave")]
        [Display(Name = "IBAN")]
        public string Iban { get; set; }

        [Required]
        [StringLength(7, ErrorMessage = "Het {0} moet minimaal {2} en maximaal {1} karakters lang zijn.", MinimumLength = 7)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Must be numeric")]
        [DataType(DataType.Text)]
        [Display(Name = "Studentnummer")]
        public string StudentNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Begindatum studie")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd'-'MM'-'yyyy}")]
        public string StartdateStudy { get; set; }
        
        [Required]
        [StringLength(30, ErrorMessage = "Studietype is ongeldig.")]
        [DataType(DataType.Text)]
        [Display(Name = "Studietype")]
        public string StudyType { get; set; }

        [StringLength(100, ErrorMessage = "Telefoonnummer is ongeldig.")]
        [DataType(DataType.Text)]
        [Display(Name = "Telefoonnummer")]
        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Status Status { get; set; }

        public String UserName { get; set; }

        [Display(Name = "Rollen")]
        public IEnumerable<CheckBoxListItem> Roles { get; set; }

    }
}
