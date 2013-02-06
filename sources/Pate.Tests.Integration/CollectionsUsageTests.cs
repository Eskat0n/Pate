namespace Pate.Tests.Integration
{
    using System.Collections.Generic;
    using Xunit;

    public class CollectionsUsageTests
    {
        private class CollectionItem
        {
            public int Int { get; set; }
            public string Label { get; set; }
            public string Text { get; set; }
        }

        private class CollectionModel
        {
            public IEnumerable<CollectionItem> Items { get; set; }

            public string Label { get; set; }

            public string Text { get; set; }
        }

        [Fact]
        public void RowOfTableWithEnumerableModel()
        {
            
        }
    }
}