using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Batch_01.Models
{
    public class District
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DistrictID { get; set; }
        [Display(Name ="District")]
        [Required]
        [StringLength(maximumLength:100)]
        public string DistrictName{ get; set; }

    }
}
