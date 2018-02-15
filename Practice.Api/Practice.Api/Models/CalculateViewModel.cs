using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Practice.Api.Models
{
    [DataContract(Name = "calculate")]
    public class CalculateViewModel
    {
        [DataMember(Name = "principal")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 1000000.0, ErrorMessage = "{0} out of range")]
        public double? Principal { get; set; }

        [DataMember(Name = "percentageRate")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(0.0, 100.0, ErrorMessage = "{0} out of range")]
        public double? Rate { get; set; }

        [DataMember(Name = "years")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 30, ErrorMessage = "{0} out of range")]
        public int? Years { get; set; }
    }
}