using System;

public interface ICartPersisting
{
    void Persist(int cartId);

    void ViewCart(int userId);
}
