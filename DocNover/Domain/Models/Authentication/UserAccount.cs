using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DocNover.Domain.Models.Authentication
{
    public class UserAccount
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_name")]
        [MaxLength(100)]
        public string? UserName {  get; set; }

        [Column("password")]
        [MaxLength(100)]
        public string? Password {  get; set; }

        [MaxLength(20)]
        [Column("role")]
        public string? Role { get; set; }
    }
}
