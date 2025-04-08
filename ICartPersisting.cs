using System;

namespace Cart
{
    public class ICartPersisting
    {
        void Persist(Cart cart);

        void ViewCart(UserId userId);
    }
}