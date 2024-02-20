using RockSeatAuction.API.Entities;

namespace RockSeatAuction.API.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
