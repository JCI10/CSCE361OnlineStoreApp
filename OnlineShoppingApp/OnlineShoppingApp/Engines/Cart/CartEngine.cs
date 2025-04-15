using System;


public class CartEngine : ICartPersisting, ICartModification, ICartMoneyhandler
{
    public void Persist(int cartId)
    {
        //TODO:Implement Method
    }

    public Cart ViewCart(int userId)
    {
        //TODO:Implement Method
    }

    public void AddProducts(int cartId, List<int> productId)
    {
        //TODO:Implement Method
    }

    public void RemoveProduct(int productId)
    {
        //TODO:Implement Method
    }

    public void Checkout(int cartId)
    {
        //TODO:Implement Method
    }
    
    public void CartTotal(int cartId)
    {
        //TODO:Implement Method
    }
}
