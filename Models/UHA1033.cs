using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UongHoangAnh2022033.Models
{
    public class UHA1033
    {
        [Key]

        [Display(Name = "Mã id")]
        public string UHAID { get; set; }
        [Required]

        [Display(Name = "Họ và Tên")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string? UHAName { get; set; }

        [Display(Name="Giới tính")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public bool? UHA { get; set; }

    }
}