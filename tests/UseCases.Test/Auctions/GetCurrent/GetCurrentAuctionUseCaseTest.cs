using FluentAssertions;
using Moq;
using RockSeatAuction.API.Contracts;
using RockSeatAuction.API.UseCases.Auctions.GetCurrent;
using RockSeatAuction.API.Entities;
using Bogus;
using RockSeatAuction.API.Enums;

namespace UseCases.Test.Auctions.GetCurrent;
public class GetCurrentAuctionUseCaseTest
{
    [Fact]
    public void Success()
    {
        var entity = new Faker<Auction>()
            .RuleFor(auction => auction.Id, f => f.Random.Number(1, 700))
            .RuleFor(auction => auction.Name, f => f.Lorem.Word())
            .RuleFor(auction => auction.Starts, f => f.Date.Past())
            .RuleFor(auction => auction.Ends, f => f.Date.Future())
            .RuleFor(auction => auction.Items, (f, auction) => new List<Item>
            {
                new Item
                {
                    Id = f.Random.Number(1, 700),
                    Name = f.Commerce.ProductName(),
                    Brand = f.Commerce.Department(),
                    BasePrice = f.Random.Decimal(50,1000),
                    Condition = f.PickRandom<Condition>(),
                    AuctionId = auction.Id
                }
            }).Generate();
        
        var mock = new Mock<IAuctionRepository>();

        mock.Setup(i => i.GetCurrent()).Returns(new Auction());
        var UseCase = new GetCurrentAuctionUseCase(mock.Object);

        var auction = UseCase.Execute();

        Assert.NotNull(auction);

        auction.Should().NotBeNull();
        auction.Id.Should().Be(entity.Id);
    }
}
