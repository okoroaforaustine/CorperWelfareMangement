using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models
{
    public class NyscYear
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int NyscYearID { get; set; }

        [Required(ErrorMessage="Nysc year is required")]
        public string NyscYearName { get; set; }
        
       
    }
}