using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystemDeutsch.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystemDeutsch.Infrastructure.Data.Models
{
    [Comment("House for Rent")]
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength), MinLength(TitleMinLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(AddressMaxLength), MinLength(AddressMinLength)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(DescriptionMaxLength), MinLength(DescriptionMinLength)]
        public string Description { get; set; } = string.Empty;

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
