using System;

namespace Domain.Aggregates.Champagne.ValueObjects
{
    public record ChampagneName
    {
        public string Value { get; set; }
        public ChampagneName(string value)
        {
            ArgumentException.ThrowIfNullOrEmpty(value);

            Value = value;
        }
    }
}