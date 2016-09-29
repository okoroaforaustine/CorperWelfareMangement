using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models
{
    public class Batch
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BatchID { get; set; }
        [Required(ErrorMessage="Batch Name is required")]
        public string BatchName { get; set; }
        


    }
}