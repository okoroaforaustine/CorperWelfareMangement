using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorpersWelfareManager.Models
{
    public class Corper
    {
        [Key]
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        

        public int CorperID { get; set; }
     
        [Required(ErrorMessage="Please Statecode is Required")]
        public string Statecode { get; set; }

        [Required(ErrorMessage="please fill in your Firstname")]
        [MaxLength(50)]
        public string Firstname { get; set; }
        public string Lastname { get; set; }

      
        public string Community { get; set; }
       
        public string Sex { get; set; }
        public virtual ICollection<MonthlyDues> MonthlyDues { get; set; }
    }
}