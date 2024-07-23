using WebApplication2.Models;

namespace WebApplication2.Helpers
{
    public static class ProductValidator
    {
        public static void Validate(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException("Name is required.");
            }
            if (string.IsNullOrWhiteSpace(product.Description))
            {
                throw new ArgumentException("Description is required.");
            }

        }
    }
}
