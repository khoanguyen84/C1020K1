using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Entities
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Image { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ICollection<MemberFood> FoodMember { get; set; }
    }
}
