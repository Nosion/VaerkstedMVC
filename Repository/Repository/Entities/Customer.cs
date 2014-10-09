using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class Customer
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Min 3 and Max 50 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Company { get; set; }
        [Required]
        [Phone]
        [RegularExpression(@"\d{8}", ErrorMessage ="Must be 8 digits")]
        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }
        public virtual IList<Car> cars { get; private set; }
    }
}
