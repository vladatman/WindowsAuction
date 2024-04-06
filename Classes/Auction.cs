using AuctionProgram.Classes.Products;
using AuctionProgram.States;
using System.Collections.Generic;

namespace AuctionProgram.Classes
{
    public class Auction
    {
        private State state;
        public List<Bidder> bidders;
        public List<Product> lots;

        public Auction(State state, List<Bidder> bidders, List<Product> lots)
        {
            setState(state);
            this.bidders = bidders;
            this.lots = lots;
        }

        public void setState(State state)
        {
            this.state = state;
            this.state.setAuction(this);
        }

        public State getState()
        {
            return this.state;
        }

        public void addBidder(Bidder bidder)
        {
            bidders.Add(bidder);
        }

        public void addLot(Product lot)
        {
            lots.Add(lot);
        }

        public void enable()
        {
            this.state.enableBidding();
        }

        public void disable()
        {
            this.state.disableBidding();
        }
    }
}
