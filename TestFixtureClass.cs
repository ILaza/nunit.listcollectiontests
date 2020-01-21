using NUnit.Framework;
using NUnit.ListCollectionTests.TestData;
using System.Collections.Generic;

namespace NUnit.ListCollectionTests
{
    [TestFixtureSource(typeof(TestFixtureDataClass), "TestFixtureCases")]
    public class TestFixtureClass
    {
        private List<int> testCollection;
        private int predict;

        public TestFixtureClass(List<int> testCollection, int predict)
        {
            this.testCollection = testCollection;
            this.predict = predict;
        }

        public TestFixtureClass(List<int> testCollection)
        {
            this.testCollection = testCollection;
        }

        [Test]
        public void ReverseTest()
        {
            var testCollectionClone = new List<int>();
            testCollectionClone.AddRange(testCollection);

            testCollection.Reverse();

            for (int i = 0; i < testCollection.Count; i++)
            {
                Assert.That(testCollection[i], Is.EqualTo(testCollectionClone[testCollection.Count - i - 1]), $"Element {testCollection[i]} not equal to {testCollectionClone[testCollection.Count-i-1]}." +
                                                                                                              $"Collection wasn't reversed.");
            }
        }

        [Test]
        public void RemoveAllTestFixture()
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

            Assert.That(testCollectionClone, Is.EquivalentTo(testCollection), "Testing colection and cloned collection are not equavalented");
        }
    }
}
