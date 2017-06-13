﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace indicium_webapp.Models.ViewModels.ManageViewModels
{
    public class ChangeEducationalInformationViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Studietype")]
        public StudyType StudyType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Begindatum studie")]
        public DateTime StartdateStudy { get; set; }
    }
}
