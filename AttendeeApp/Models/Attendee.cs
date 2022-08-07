using System.ComponentModel.DataAnnotations;

namespace AttendeeApp.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        public int UID { get; set; }

        [Required(ErrorMessage = "아이디를 입력하세요.")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "아이디를 확인하세요.")]
        public string? UserID { get; set; }

        [Required(ErrorMessage = "이름을 입력하세요.")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "이름을 확인하세요.")]
        public string? Name { get; set; }

        public DateTime CreationDate { get; set; }
    }
}

