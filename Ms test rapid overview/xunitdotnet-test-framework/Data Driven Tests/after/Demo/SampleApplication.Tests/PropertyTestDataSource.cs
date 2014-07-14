using System.Collections.Generic;

namespace SampleApplication.Tests
{
    public static class PropertyTestDataSource
    {
        private static List<object[]> _data = new List<object[]>
                                              {
                                                  new object[] {9, true},
                                                  new object[] {10, false},
                                                  new object[] {11, false},
                                                  new object[] {-1, true},
                                                  new object[] {100, true}
                                              };

        public static IEnumerable<object[]> TestData
        {
            get { return _data; }
        }
    }
}