using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Coyote;
using Microsoft.Coyote.SystematicTesting;
using NUnit.Framework;

namespace CoyoteUnitTesting.Tests
{
    [TestFixture]
    public class Tests
    {
        [NUnit.Framework.Test]
        public void Running_CoyoteTest_ShouldWork()
        {
            var config = Configuration.Create()
                .WithTestingIterations(1000)
                .WithDeadlockTimeout(1000000)
                .WithVerbosityEnabled();
            var engine = TestingEngine.Create(config, CoyoteTestMethod);
            engine.Run();
            var report = engine.TestReport;
            Console.WriteLine("Coyote found {0} bug.", report.NumOfFoundBugs);
            Console.WriteLine($"{report.BugReports.First()}");
            Assert.True(report.NumOfFoundBugs == 0, $"Coyote found {report.NumOfFoundBugs} bug(s).");
        }

        private async Task CoyoteTestMethod()
        {
            var fr = new Class1();
            var t1 = fr.UpdateCounter(1);
            var t2 = fr.UpdateCounter(2);
            await Task.WhenAll(t1, t2);

            Assert.AreEqual(1, fr.Counter);
        }
    }
}
