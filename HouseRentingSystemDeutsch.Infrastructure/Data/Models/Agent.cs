using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystemDeutsch.Infrastructure.Data.Models
{
    [Comment("Agent info")]
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15), MinLength(7)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        public IdentityUser User { get; set; } = null!;

        public List<House> House { get; set; } = new List<House>();
    }
}
