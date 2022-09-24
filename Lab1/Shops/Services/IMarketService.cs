using Shops.Models;

namespace Shops.Services
{
    public interface IMarketService
    {
        Shop AddShop();

        Buyer AddBuyer();

        void TopUpBalance(Buyer buyer, decimal money);

        void SupplyShop(Shop shop, List<Container> products);

        Order MakeOrder(Buyer buyer, Shop shop, List<Container> products);

        /// something else
    }
}
