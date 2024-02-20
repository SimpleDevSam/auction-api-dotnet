using Microsoft.AspNetCore.Mvc;
using RockSeatAuction.API.Communication.Requests;
using RockSeatAuction.API.Filters;
using RockSeatAuction.API.UseCases.Offers.CreateOffer;

namespace RockSeatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]

public class OfferController : RocketSeatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]

    public IActionResult CreateOffer(
        [FromRoute]int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId,request);
        return Created(string .Empty,id);
    }
}
