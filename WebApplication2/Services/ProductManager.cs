using WebApplication2.Models;
using WebApplication2.Helpers;
using WebApplication2.Exceptions;


namespace WebApplication2.Services
{
    public class ProductManager
    {
        //here we have a list of the products 
        private List<Product> _products = new List<Product>();
        //created a dictionary to acccess each of the products
        private Dictionary<int, Product> _productDictionary = new Dictionary<int, Product>();

        //add void function so the user can add a product
        public void AddProduct(Product product)
        {
            _products.Add(product);
            _productDictionary[product.Id] = product;
        }

       

        public void DeleteProduct(int productId)
        {
            var contact = _products.FirstOrDefault(c => c.Id == productId);
            if (contact != null)
            {
                _products.Remove(contact);
                _productDictionary.Remove(productId);
            }
        }

        public IEnumerable<Product> ListContacts()
        {
            return _products;
        }

       

        public Product GetProductById(int productId)
        {
            _productDictionary.TryGetValue(productId, out var product);
            return product;
        }

        
       

        public void AddContact(Product product)
        {
            ProductValidator.Validate(product);
            if (_products.Any(c => c.Id == product.Id))
            {
                throw new DuplicateIdException($"Product with ID {product.Id} already exists.");
            }

        }

        //Update and existing Product

        public void UpdateProduct(Product product)
        {
            ProductValidator.Validate(product);
            try
            {

                var existingProduct = _products.FirstOrDefault(c => c.Id == product.Id);
                if (existingProduct == null)
                {
                    throw new IdNotFoundException($"Product with ID {product.Id} not found.");
                }
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.StockAmount = product.StockAmount;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating product: {ex.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("UpdateProduct method execution finished.");
            }
        }
    }
}
