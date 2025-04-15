using System;

public interface ICartModification
{
    void AddProducts(int cartId, List<int> productIds);
    
    void RemoveProduct(int cartId, int productId);
    
}

