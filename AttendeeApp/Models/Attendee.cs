using System.ComponentModel.DataAnnotations;

namespace AttendeeApp.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "UID를 입력하세요.")]
        public int UID { get; set; }

        [Display(Name = "아이디")]
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "아이디를 확인하세요.")]
        public string? UserID { get; set; }

        [Display(Name = "이름")]
        [Required(ErrorMessage = "이름을 입력하세요.")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "이름을 확인하세요.")]
        public string? Name { get; set; }

        public DateTime CreationDate { get; set; }
    }
}

