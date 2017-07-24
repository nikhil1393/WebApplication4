using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Models
{
    public class UserModels
    {
        [DisplayName("Name")]
        [Required (ErrorMessage="Name is required")]
  public      string Name { get; set; }
        [Required]
        public string Age { get;set; }
        [Required]
        [StringLength (4)]
        public string no { get; set; }


        [Required(ErrorMessage = "A is required")]
        [Range (1,50)]
public int A { get; set; }

        [Remote("chkno", "User")]
        public int B { get; set; }



        public int Result { get; set; }
    }
}
