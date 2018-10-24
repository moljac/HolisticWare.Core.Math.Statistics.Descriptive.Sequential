﻿using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;


namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// </summary>
    public static partial class IEnumerableExtensionsFrequencies
    {
#if NETSTANDARD1_3
        [Obsolete("Performance issue (boxing)")]
        public static Dictionary<object, uint> FrequencyCounter(this System.Collections.ArrayList x)
        {
            long n = x.Count;

            Dictionary<object, uint> frequencies = new Dictionary<object, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                object x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            return frequencies;
        }
#endif
    }
}
