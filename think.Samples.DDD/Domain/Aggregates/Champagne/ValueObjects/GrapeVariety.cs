using System;
using System.Linq;

namespace Domain.Aggregates.Champagne.ValueObjects
{
    public class GrapeVariety
    {
        public string Value { get; set; }
        
        private readonly string[] _allowedGrapeTypes = 
        {
            "Chardonnay",
            "PinotNoir",
            "PinotMeunier",
            "PinotBlanc",
            "PinotGris",
            "Arbane",
            "PetitMeslier"
        };

        public GrapeVariety(string value)
        {
            ArgumentException.ThrowIfNullOrEmpty(value);

            if (!_allowedGrapeTypes.Contains(value))
                throw new ArgumentException($"Grape '{value}' is not allowed in a champagne", nameof(value));

            Value = value;
        }
    }
}