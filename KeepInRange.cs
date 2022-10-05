using System;

namespace ExcelMigrator.DataObjects
{
    public class KeepInRange
    {
        public static T Clamp<T>(T value, T min, T max) where T : IComparable
        {
            // todo - implementation
            T output = value;
            if (value.CompareTo(max) > 0)
            {
                return max;
            }
            if (value.CompareTo(min) < 0)
            {
                return min;
            }
            return output;
        }
    }
}
