using System;

namespace Cart
{
    public interface ICartModification
    {
        void AddProducts(userId userId, List<Product> products);
        
        void RemoveProduct(productId productId);
      
    }
}
