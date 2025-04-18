using System;
using OnlineShoppingApp.Models;

public interface ICartPersisting
{
    Task Persist(int cartId);

    Task<List<Product>> ViewCart(int userId);
}
