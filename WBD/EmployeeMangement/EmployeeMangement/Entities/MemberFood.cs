using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Entities
{
    public class MemberFood
    {
        [Key]
        public int MemberFoodId { get; set; }
        public int MemberId { get; set; }
        public Member Members { get; set; }
        public int FoodId { get; set; }
        public Food Foods { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
    }
}
