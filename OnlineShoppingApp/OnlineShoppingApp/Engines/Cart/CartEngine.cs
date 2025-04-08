using System;

namespace Engines
{
    public class CartEngine : ICartPersisting, ICartModification, ICartMoneyhandler
    {
        public void Persist(Cart cart)
        {
            //TODO:Implement Method
        }

        public Cart ViewCart(UserId userId)
        {
            //TODO:Implement Method
        }

        public void AddProducts(userId userId, List<Product> products)
        {
            //TODO:Implement Method
        }

        public void RemoveProduct(productId productId)
        {
            //TODO:Implement Method
        }

        public void Checkout(Cart cart)
        {
            //TODO:Implement Method
        }
        
        public void CartTotal(Cart cart)
        {
            //TODO:Implement Method
        }
    }
}
