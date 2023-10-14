using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace bahare_zorufchi.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public class UserMetadata
        {
            public long ID { get; set; }

            [Display(Name = "نام کاربری")]
            [Required(ErrorMessage = "انتخاب نام کاربری اجباری است")]
            public string UserName { get; set; }

            [Display(Name = "رمز عبور")]
            [DataType(DataType.Password)]
            [Required(ErrorMessage = "انتخاب رمز عبور اجباری است")]
            public string Password { get; set; }

            [Display(Name = "تکرار رمز عبور")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "کلمه عبور و تکرار آن یکسان نمی باشند.")]
            [Required(ErrorMessage = "تکرار کلمه عبور نمی تواند خالی باشد")]
            public string ConfirmPassword { get; set; }

            [Display(Name = "ایمیل")]
            [Required(ErrorMessage = "انتخاب ایمیل اجباری است")]
            public string Email { get; set; }

            [Display(Name = "شماره تماس")]
            [Required(ErrorMessage = "انتخاب شماره تماس اجباری است")]
            public string Phone { get; set; }
        }
    }
}