﻿using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see cref="http://www.mathsisfun.com/data/correlation.html"/>
    public static partial class IEnumerableExtensionsCorrelation
    {
        public static double CorrelationOptimized(this IEnumerable<double> x, IEnumerable<double> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                double y_i = y.ElementAt(i);

                sum_x += x_i;
                sum_y += y_i;
                sum_x_pow_2 += x_i * x_i;
                sum_y_pow_2 += y_i * y_i;
                sum_product_x_y += x_i * y_i;
            }

            double correlation =
                (n * sum_product_x_y - sum_x * sum_y)
                /
                (
                    System.Math.Sqrt((n * sum_x_pow_2) - sum_x * sum_x)
                    *
                    System.Math.Sqrt((n * sum_y_pow_2) - sum_y * sum_y)
                )
                ;

            return correlation;
        }

        public static double Correlation(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double standard_deviation_x = x.StandardDeviationSample();
            double standard_deviation_y = y.StandardDeviationSample();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<int>().Average();
            double y_mean_average_arithmetic = y.Cast<int>().Average();

            return 
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double standard_deviation_x = x.StandardDeviationSample();
            double standard_deviation_y = y.StandardDeviationSample();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<long>().Average();
            double y_mean_average_arithmetic = y.Cast<long>().Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double standard_deviation_x = x.StandardDeviationSample();
            double standard_deviation_y = y.StandardDeviationSample();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double standard_deviation_x = x.StandardDeviationSample();
            double standard_deviation_y = y.StandardDeviationSample();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<long>().Average();
            double y_mean_average_arithmetic = y.Cast<long>().Average();


            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double standard_deviation_x = x.StandardDeviationSample();
            double standard_deviation_y = y.StandardDeviationSample();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;        
        }

        public static double Correlation(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double standard_deviation_x = x.StandardDeviationSample();
            double standard_deviation_y = y.StandardDeviationSample();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Cast<double>().Average();
            double y_mean_average_arithmetic = y.Cast<double>().Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;        
        }

        public static double Correlation(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double standard_deviation_x = x.StandardDeviationSample();
            double standard_deviation_y = y.StandardDeviationSample();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            double x_mean_average_arithmetic = x.Average();
            double y_mean_average_arithmetic = y.Average();

            return
                (sum - n * x_mean_average_arithmetic * y_mean_average_arithmetic)
                /
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;        
        }

        public static decimal Correlation(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal standard_deviation_x = x.StandardDeviationSample();
            decimal standard_deviation_y = y.StandardDeviationSample();

            decimal sum = 0.0M;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Average() * y.Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }
    }
}