using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.ListCollectionTests.TestData
{
    public class TestCaseDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 5);
                yield return new TestCaseData(new List<int>() { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 5);
                yield return new TestCaseData(new List<int>() { 11, 22, 33, 44, 55, 66, 77, 88, 99, 00 }, 5);
                yield return new TestCaseData(new List<int>() { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 }, 5);
                yield return new TestCaseData(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 5);
            }
        }

        public static int predictForRemoveAll = 5;
    }
}
