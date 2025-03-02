using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace MusiCodeWebApp.Models
{
	public class Category : Entity
	{
        public Category() 
        {
            IsDeleted = false;
            IsActive = true;
        }

        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 75, ErrorMessage = "Bu Alan En Fazla 75 Karakter Olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [DataType(DataType.MultilineText)]
        [StringLength(maximumLength: 500, ErrorMessage = "Bu Alan En Fazla 500 Karakter Olmalıdır")]
        public string Description { get; set; }

        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
    }
}