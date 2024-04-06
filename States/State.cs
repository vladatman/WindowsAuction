namespace AuctionProgram.States
{
    public abstract class State
    {
        protected AuctionProgram.Classes.Auction auction;

        public void setAuction(AuctionProgram.Classes.Auction auction)
        {
            this.auction = auction;
        }

        public abstract void enableBidding();
        public abstract void disableBidding();
    }
}
