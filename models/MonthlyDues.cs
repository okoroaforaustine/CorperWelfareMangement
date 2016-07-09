using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorpersWelfareManager.Models
{
    public class MonthlyDues
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MonthlyID { get; set; }
       public int CorperID { get; set; }

       public string Month { get; set; }
        public double AmountMonthly { get; set; }

   
        public bool Paid { get; set; }
       
        public virtual Corper Corper { get; set; }

    }
}