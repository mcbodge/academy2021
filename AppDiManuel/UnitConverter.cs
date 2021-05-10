using System;

namespace AppDiManuel.Converters
{
    public class UnitConverter
    {
        // Constructor -> FUNC
        public UnitConverter(int unitRatio)
        {
            ratio = unitRatio;
        }
        public UnitConverter(int unitRatio, int secondRatio)
        {
            ratio = unitRatio;
        }

        // Field -> DATUM
        int ratio;

        // Method -> FUNC
        public int Convert(int value)
        {
            return value * ratio;
        }
    }
}
