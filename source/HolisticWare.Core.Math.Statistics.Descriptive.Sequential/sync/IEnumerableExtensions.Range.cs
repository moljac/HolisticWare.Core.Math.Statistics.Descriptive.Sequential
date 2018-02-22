﻿using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static partial class IEnumerableExtensionsRange
    {
        //==============================================================================================================
        public static (byte min, byte max) Range(this IEnumerable<byte> x)
        {
            byte min = x.Min();
            byte max = x.Max();

            return (min, max);
        }

        public static (short min, short max) Range(this IEnumerable<short> x)
        {
            short min = x.Min();
            short max = x.Max();

            return (min, max);
        }

        public static (ushort min, ushort max) Range(this IEnumerable<ushort> x)
        {
            ushort min = x.Min();
            ushort max = x.Max();

            return (min, max);
        }

        public static (int min, int max) Range(this IEnumerable<int> x)
        {
            int min = x.Min();
            int max = x.Max();

            return (min, max);
        }

        public static (uint min, uint max) Range(this IEnumerable<uint> x)
        {
            uint min = x.Min();
            uint max = x.Max();

            return (min, max);
        }

        public static (long min, long max) Range(this IEnumerable<long> x)
        {
            long min = x.Min();
            long max = x.Max();

            return (min, max);
        }

        public static (ulong min, ulong max) Range(this IEnumerable<ulong> x)
        {
            ulong min = x.Min();
            ulong max = x.Max();

            return (min, max);
        }

        public static (float min, float max) Range(this IEnumerable<float> x)
        {
            float min = x.Min();
            float max = x.Max();

            return (min, max);
        }

        public static (double min, double max) Range(this IEnumerable<double> x)
        {
            double min = x.Min();
            double max = x.Max();

            return (min, max);
        }

        public static (decimal min, decimal max) Range(this IEnumerable<decimal> x)
        {
            decimal min = x.Min();
            decimal max = x.Max();

            return (min, max);
        }
        //==============================================================================================================

    }
}
