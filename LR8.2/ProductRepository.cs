public static class ProductRepository
{
    static List<Product> Products = new List<Product>();

    public static IList<Product> GetProductList() => Products;

    public static bool AddProduct(Product? product)
    {
        if (product == null)
        {
            return false;
        }
        Products.Add(product);
        return true;
    }

    public static void init()
    {
        Products = new List<Product> {
        };
    }
}