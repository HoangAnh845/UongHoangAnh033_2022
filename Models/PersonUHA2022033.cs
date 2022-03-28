using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UongHoangAnh2022033.Models
{
    [Table("Persons")]
    public class PersonUHA2022033
    {
        [Key]

        [Display(Name = "Mã id")]
        public string PersonID { get; set; }
        [Required]

        [Display(Name = "Họ và Tên")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string PersonName { get; set; }

    }
}