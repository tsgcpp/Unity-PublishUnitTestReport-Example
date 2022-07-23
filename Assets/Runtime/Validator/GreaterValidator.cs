using System;

namespace Validator
{
    public sealed class GreaterValidator
    {
        public GreaterValidator(float border)
        {
            if (float.IsInfinity(border))
            {
                throw new ArgumentException("\"border\" must not be infinity");
            }

            Border = border;
        }

        public float Border { get; }

        public bool Validate(float value)
        {
            return value > Border;
        }
    }
}
