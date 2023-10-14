using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;  

namespace bahare_zorufchi.Models
{
    public class pasokh
    {
       
        public string NameFamily { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد الزامی است")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد الزامی است")]
        public string Text { get; set; }
        public string Email { get; set; }
        public bool willsend { get; set; }
        public bool Issatisfied { get; set; }
    }
}