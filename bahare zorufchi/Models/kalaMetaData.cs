using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace bahare_zorufchi.Models
{
    [MetadataType(typeof(kalaMetaData))]
    public partial class kala
    {
        
        public class kalaMetaData
        {
            public long ID { get; set; }
            [Display (Name = "گروه کالا")]
            [Required(ErrorMessage ="انتخاب گروه کالا اجباری است")]
            public Nullable<int> categoryID { get; set; }
            [Display(Name = "نام")]
            [Required(ErrorMessage = "نام نمی تواند خالی باشد")]
            public string Name { get; set; }
            [Display(Name = "تولید کنندها")]
            [Required(ErrorMessage = "فیلد تولید کننده نمی تواند خالی باشد")]
            public string Producer { get; set; }
            [Display(Name = "توضیحات")]
            [Required(ErrorMessage = "فیلد تولید کننده نمی تواند خالی باشد")]
            public string Description { get; set; }
            [Display(Name = "انتخاب عکس")]
            public string ImageURL { get; set; }
            [Display(Name = "قیمت اصلی")]
            [Required(ErrorMessage = "فیلد تولید کننده نمی تواند خالی باشد")]
            public int Original_Price { get; set; }
            [Display(Name = "قیمت با تخفیف")]
            [Required(ErrorMessage = "فیلد تولید کننده نمی تواند خالی باشد")]
            public int Discount_Price { get; set; }
            public bool IsAvailable { get; set; }

        }
    }
}