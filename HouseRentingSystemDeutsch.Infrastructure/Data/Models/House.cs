using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentingSystemDeutsch.Infrastructure.Data.Models
{
    [Comment("House for Rent")]
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50), MinLength(10)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(150), MinLength(30)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(500), MinLength(50)]
        public string Discription { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public IdentityUser Renter { get; set; } = null!;
    }
}
