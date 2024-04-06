using AuctionProgram.Classes.Products;

namespace AuctionProgram.Classes
{
    public interface IObserver
    {
        void update(Product lot);
    }
}
