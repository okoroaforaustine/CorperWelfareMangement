using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CorpersWelfareManager.Models
{
    public class Community
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CommunityID { get; set; }

        [Required(ErrorMessage=" Community Name is required")]
        public string CommunityName { get; set; }
        

     
    }
}