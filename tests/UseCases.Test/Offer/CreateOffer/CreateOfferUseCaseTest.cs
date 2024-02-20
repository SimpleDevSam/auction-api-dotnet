using Bogus;
using FluentAssertions;
using Moq;
using RockSeatAuction.API.Communication.Requests;
using RockSeatAuction.API.Contracts;
using RockSeatAuction.API.Entities;
using RockSeatAuction.API.Services;
using RockSeatAuction.API.UseCases.Offers.CreateOffer;

namespace UseCases.Test.Auctions.GetCurrent;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Success(int itemId)
    {
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 700))
            .Generate();

        var mock = new Mock<IOfferRepository>();
        var loggedUser = new Mock <ILoggedUser>();
        loggedUser.Setup(i=>i.User()).Returns(new User());

        var UseCase = new CreateOfferUseCase(loggedUser.Object,mock.Object);

        var act = () => UseCase.Execute(itemId, request);

        act.Should().NotThrow();

    }
}
