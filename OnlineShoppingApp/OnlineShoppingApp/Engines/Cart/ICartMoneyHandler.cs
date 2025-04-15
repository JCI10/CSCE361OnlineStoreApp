using System;

public interface ICartMoneyHandler
{
    void Checkout(int cartId);

    void CartTotal(int cartId);
}

