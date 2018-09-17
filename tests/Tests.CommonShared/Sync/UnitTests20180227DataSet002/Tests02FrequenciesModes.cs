﻿// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
using TestContext = HolisticWare.Core.Testing.UnitTests.TestContext;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Collections.ObjectModel;

using Core.Math.Statistics.Descriptive.Sequential;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync
{
    public partial class UnitTests20180227DataSet002
    {
        Dictionary<int, (uint, double, uint)> fc = 
                new Dictionary<int, (uint, double, uint)>()
                                    {
                                        { 24, ( 2, 0.1, 3 ) },
                                        { 28, ( 2, 0.1, 3 ) },
                                        { 29, ( 2, 0.1, 3 ) },
                                        { 22, ( 1, 0.1, 3 ) },
                                        { 33, ( 1, 0.1, 3 ) },
                                        { 25, ( 1, 0.1, 3 ) },
                                        { 36, ( 1, 0.1, 3 ) },
                                        { 27, ( 1, 0.1, 3 ) },
                                        { 34, ( 1, 0.1, 3 ) },
                                        { 32, ( 1, 0.1, 3 ) },
                                        { 21, ( 1, 0.1, 3 ) },
                                        { 30, ( 1, 0.1, 3 ) },
                                        { 35, ( 1, 0.1, 3 ) },
                                    };

        [Test()]
        public void Frequencies()
        {
            //====================================================================================================
            // Arrange
            // Arrange
            List<int> data_list01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            // Act
            IEnumerable<KeyValuePair<int, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = data_list.Frequencies();

            sw.Stop();
            Console.WriteLine($"List<int>.Frequencies()");
            Console.WriteLine($"          f      = {f}");
            Console.WriteLine($"          size               = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]     = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]        = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();


            return;
        }

        [Test()]
        public void Mode01()
        {
            //====================================================================================================
            // Arrange
            List<int> data_list01 = new List<int> { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes01 = data_list.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes01               = {modes01}");
            Console.WriteLine($"          size                  = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                                (
                                    new List<int> { 24, 28, 29 },
                                    modes01
                                );
            #elif XUNIT
            Assert.Equal
                                (
                                    new List<int> { 24, 28, 29 },
                                    modes01
                                );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                                (
                                    new List<int> { 24, 28, 29 },
                                    modes01
                                );
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode02()
        {
            //====================================================================================================
            // Arrange
            Stack<int> data02 = new Stack<int>(new[] { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 });

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes02 = data02.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes02               = {modes02}");
            Console.WriteLine($"          size                  = {data02.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes02
                                    );
            #elif XUNIT
            modes02.Sort();
            Assert.Equal
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes02
                                    );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes02
                                    );
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode03()
        {
            //====================================================================================================
            // Arrange
            Queue<int> data03 = new Queue<int>(new[] { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 });

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes03 = data03.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes03               = {modes03}");
            Console.WriteLine($"          size                  = {data03.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes03
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes03
                                    );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes03
                                    );
            #endif
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode04()
        {

            //====================================================================================================
            // Arrange
            int[] data04 = new[] { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes04 = data04.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes04               = {modes04}");
            Console.WriteLine($"          size                  = {data04.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            #if NUNIT && !NUNIT_LITE            CollectionAssert.AreEquivalent                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes04
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes04
                                    );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes04
                                    );
            #endif
            //====================================================================================================
        }

        [Test()]
        public void Mode05()
        {
            #if NETSTANDARD1_3
            //====================================================================================================
            // Arrange
            ArrayList data05 = new ArrayList { 22, 24, 33, 25, 36, 27, 34, 24, 32, 21, 28, 29, 30, 35, 29, 28 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes05 = data05.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.MeanGeneralized()");
            Console.WriteLine($"          modes05               = {modes05}");
            Console.WriteLine($"          size                  = {data_list.Count()}");
            Console.WriteLine($"          elapsed[ticks]        = {sw.ElapsedTicks}");
            Console.WriteLine($"          elapsed[ms]           = {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            // Assert
            CollectionAssert.AreEquivalent
                                    (
                                        new List<int> { 24, 28, 29 },
                                        modes05
                                    );
            //====================================================================================================
            #endif

            return;
        }

    }
}
