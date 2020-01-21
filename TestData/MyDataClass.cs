using System.Collections.Generic;
using System;

namespace NUnit.ListCollectionTests
{
    public class MyDataClass
    {
        private static List<int> testCollection;
        public static int testElement = 5;
        public static int[] argumentsForGetRangeMethod = new int[2];

        public static List<int> CreateCollectionWithRandomValuesAndRandomCount()
        {
            var rand = new Random();
            var countOfCollection = rand.Next(4, 51);
            testCollection = new List<int>();
            for(int i = 0; i < countOfCollection; i++)
            {
                testCollection.Add(rand.Next(4, 101));
            }
            argumentsForGetRangeMethod[0] = 0;
            argumentsForGetRangeMethod[1] = (testCollection.Count) / 2;
            return testCollection;
        }
        public static List<int> CreateCollectionWithRandomValues(int count)
        {
            var rand = new Random();
            testCollection = new List<int>();
            for (int i = 0; i < count; i++)
            {
                testCollection.Add(rand.Next(101));
            }
            argumentsForGetRangeMethod[0] = 0;
            argumentsForGetRangeMethod[1] = count / 2;
            return testCollection;
        }
    }
}
