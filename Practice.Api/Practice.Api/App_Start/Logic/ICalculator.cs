using Practice.Api.Models;

namespace Practice.Api.Logic
{
    public interface ICalculator
    {
        double? CalculateInterest(CalculateViewModel model);
    }
}