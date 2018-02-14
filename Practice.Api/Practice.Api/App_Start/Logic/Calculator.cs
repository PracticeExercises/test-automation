using System;
using Practice.Api.Models;

namespace Practice.Api.Logic
{
    public class Calculator : ICalculator
    {
        public double? CalculateInterest(CalculateViewModel model)
        {
            var principal = model.Principal;
            var rate = 1.0 + model.Rate / 100;
            var multiplier = Math.Pow(rate ?? 0.0, model.Years ?? 0.0);

            return principal * multiplier;
        }
    }
}