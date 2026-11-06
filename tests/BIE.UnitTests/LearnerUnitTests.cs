using BIE.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BIE.UnitTests;

[TestClass]
public class LearnerUnitTests
{
    [TestMethod]
    public void TouristAt30DaysIsApproved()
    {
        Entry entry = new Entry("Sam Test", "Orion", "Tourismus", 30, false, false, false, true);
        Verdict expected = new Verdict("approved", "Einreise bewilligt. Verhalten Sie sich unauffällig. Die Menschheit hat bereits genug Fragen.");

        Verdict result = EntryPolicy.Evaluate(entry);

        Assert.AreEqual<Verdict>(result, expected);
    }
}
