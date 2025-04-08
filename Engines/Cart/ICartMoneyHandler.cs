using System;

namespace Cart
{
    public class ICartMoneyHandler
    {
        void Checkout(Cart cart);

        void CartTotal(Cart cart);
}
}
