using System;

namespace Cart
{
    public interface ICartPersisting
    {
        void Persist(Cart cart);

        void ViewCart(UserId userId);
    }
}
