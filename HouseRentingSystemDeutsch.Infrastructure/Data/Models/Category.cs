using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystemDeutsch.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystemDeutsch.Infrastructure.Data.Models
{
    [Comment("House Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameCategoryLength)]
        public string Name { get; set; } = string.Empty;

        public List<House> Houses { get; set; } = new List<House>();
    }
}
