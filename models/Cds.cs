using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models
{
    public class Cds
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CdsID { get; set; }

        [Required(ErrorMessage="Cds Name is requied")]
        public string CdsName { get; set; }
       
       

    }
}