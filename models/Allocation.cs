using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorpersWelfareManager.Models
{
    public class Allocation
    {

       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AllocationID { get; set; }

        public string AllocationName { get; set; }
        public double Amount { get; set; }

        
    }
}