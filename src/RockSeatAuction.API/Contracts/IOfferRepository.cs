using RockSeatAuction.API.Entities;

namespace RockSeatAuction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
