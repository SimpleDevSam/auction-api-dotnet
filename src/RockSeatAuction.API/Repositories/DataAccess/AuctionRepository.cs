using Microsoft.EntityFrameworkCore;
using RockSeatAuction.API.Contracts;
using RockSeatAuction.API.Entities;


namespace RockSeatAuction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly RocketSeatAuctionDbContext _dbContext;
    public AuctionRepository(RocketSeatAuctionDbContext dbContext) => _dbContext = dbContext;


    public Auction? GetCurrent()
    {
        var today = DateTime.Now;
        //var today = new DateTime(2024, 01, 25);

        return _dbContext
         .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
