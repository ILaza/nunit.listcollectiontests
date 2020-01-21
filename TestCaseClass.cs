using NUnit.Framework;
using NUnit.ListCollectionTests.TestData;
using System.Collections.Generic;

namespace NUnit.ListCollectionTests
{
    public class TestCaseClass
    {
        [Test]
        [TestCaseSource(typeof(TestCaseDataClass), "TestCases")]
        public void RemoveAllTest(List<int> testCollection, int predict)
        {
            var testCollectionClone = new List<int>();
            testCollectionClone.AddRange(testCollection);

            for (int i = testCollection.Count - 1; i >= 0; i--)
            {
                if (testCollection[i] > predict)
                {
                    testCollection.Remove(testCollection[i]);
                }
            }
            testCollectionClone.RemoveAll(x => x > predict);

            Assert.That(testCollectionClone, Is.EquivalentTo(testCollection));
        }
    }
}