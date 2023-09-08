namespace DevCoaching.LINQ
{
    internal class Except_Intersect
    {
        public void ProcessLists(ICollection<int> first, ICollection<int> second, ICollection<int> excluded)
        {
            var allIds = first.Concat(second);

            var idsToProcess = allIds.Except(excluded);

            var idsInBothLists = first.Intersect(second);

            var unique = allIds.Distinct();

        }

        public void ProcessLists(ICollection<Product> first, ICollection<Product> second, ICollection<Product> excluded)
        {
            var allProducts = first.Concat(second);

            var productsToProcess = allProducts.Except(excluded, new ProductComparer());

            var productsInBothLists = first.Intersect(second, new ProductComparer());

            var unique = allProducts.Distinct(new ProductComparer());

        }

        public class Product
        {
            public int Id { get; set; }
            public string Sku { get; set; }
        }

        public class ProductComparer : IEqualityComparer<Product>
        {
            bool IEqualityComparer<Product>.Equals(Product? x, Product? y)
            {
                return x.Sku == y.Sku;
            }

            int IEqualityComparer<Product>.GetHashCode(Product obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
