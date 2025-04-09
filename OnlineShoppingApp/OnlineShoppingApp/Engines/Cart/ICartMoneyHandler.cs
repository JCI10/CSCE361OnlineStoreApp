using System;

namespace Cart
{
    public interface ICartMoneyHandler
    {
        void Checkout(Cart cart);

        void CartTotal(Cart cart);
}
}
