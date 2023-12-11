using System;
using System.Collections.Generic;

namespace Domain.Aggregates.Champagne.ValueObjects
{
    public record GrapeBlend
    {
        public GrapeBlendPercentage Percentage { get; private set; }
        public GrapeVariety GrapeVariety { get; private set; }
        
        public GrapeBlend(GrapeBlendPercentage percentage, GrapeVariety grape)
        {
            if (percentage == null)
                throw new ArgumentException(null, nameof(percentage));
            
            if(grape == null)
                throw new ArgumentException(null, nameof(grape));

            Percentage = percentage;
            GrapeVariety = grape;
        }
    }
}