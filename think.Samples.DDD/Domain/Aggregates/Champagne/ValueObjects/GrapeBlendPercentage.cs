using System;

namespace Domain.Aggregates.Champagne.ValueObjects
{
    public record GrapeBlendPercentage
    {
        public double Value { get; set; }
        public GrapeBlendPercentage(double value)
        {
            if(value is <= 0 or > 1) 
                throw new ArgumentException("Percentage must be between ]0..1]", nameof(value));

            Value = value;
        }
    }
}