using System;

namespace Cart
{
    public class ICartModification
    {
        void AddProducts(userId userId, List<Product> products);
        
        void RemoveProduct(productId productId);
      
    }
}
