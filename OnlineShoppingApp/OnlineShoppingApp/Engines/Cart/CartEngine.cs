using System;
using OnlineShoppingApp.Models;


public class CartEngine : ICartPersisting, ICartModification, ICartMoneyHandler
{
    public void Persist(int cartId)
    {
        //TODO:Implement Method
    }

    public void ViewCart(int userId)
    {
        //TODO:Implement Method
    }

    public void AddProducts(int cartId, List<int> productId)
    {
        //TODO:Implement Method
    }

    public void RemoveProduct(int cartId, int productId)
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

