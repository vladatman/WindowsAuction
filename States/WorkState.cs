using AuctionProgram.Classes.Products;
using AuctionProgram.States;

namespace Auction.States
{
    class WorkState : State
    {
        public override void enableBidding()
        {
            foreach (Product lot in auction.lots)
            {
                lot.buyButton.Enabled = true;
                lot.render();
            }
            this.auction.setState(this);
        }
        public override void disableBidding()
        {
            foreach (Product lot in auction.lots)
            {
                lot.buyButton.Enabled = false;
                lot.render();
            }
            this.auction.setState(this);
        }
    }
}
