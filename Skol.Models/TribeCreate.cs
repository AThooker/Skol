using Skol.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skol.Models
{
    public class TribeCreate
    {
        [Required]
        [Display(Name = "Tribe Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Tribe Colors")]
        public Colors Colors { get; set; }
    }
}
