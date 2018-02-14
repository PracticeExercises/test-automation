using System.Runtime.Serialization;

namespace Practice.Api.Models
{
    [DataContract(Name = "calculate")]
    public class CalculateViewModel
    {
        [DataMember(Name = "principal")]
        public double? Principal { get; set; }
        [DataMember(Name = "percentageRate")]
        public double? Rate { get; set; }
        [DataMember(Name = "years")]
        public int? Years { get; set; }
    }
}