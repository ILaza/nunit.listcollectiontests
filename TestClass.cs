// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace NUnit.ListCollectionTests
{
    [TestFixture]
    public class MyTests
    {
        List<int> testCollection;

        [OneTimeSetUp]
        public void Setup()
        {
            testCollection = MyDataClass.CreateCollectionWithRandomValuesAndRandomCount();
        }

        [Test]
        public void AddElementToCollection()
        {
            var count = testCollection.Count;
            testCollection.Add(MyDataClass.testElement);
            var countAfterAdding = testCollection.Count;

            Assert.That((countAfterAdding - count).Equals(1));
        }

        [Test]
        public void SortCollection()
        {
            testCollection.Sort();
            for (int i = 0; i < testCollection.Count - 1; i++)
            {
                Assert.That(testCollection[i] <= testCollection[i + 1]);
            }
        }

        [Test]
        public void CountOfCollection()
        {
            int count = 0;
            foreach (var item in testCollection)
            {
                count++;
            }
            int countOfCollection = testCollection.Count;

            Assert.That(countOfCollection.Equals(count));
        }

        [Test]
        public void GetRangeTest()
        {
            var rangCollection = testCollection.GetRange(MyDataClass.argumentsForGetRangeMethod[0], MyDataClass.argumentsForGetRangeMethod[1]);
            var countOfRangCollection = rangCollection.Count;
            var countOfTestCollection = testCollection.Count;
            Assert.Multiple(() =>
            {
               Assert.That((countOfRangCollection <= countOfTestCollection), Is.True);
               Assert.That(rangCollection, Is.SubsetOf(testCollection));
            }
           );                
        }

        [OneTimeTearDown]
        public void Teardown()
        {
           try
           { 
                testCollection.Clear();               
                
           }
           catch (NullReferenceException ex)
           {
                throw new NullReferenceException(ex.Message);
           }
           catch
           {
                throw new Exception("Test collection wasn't deleted"); 
           }
        }
    }
}
