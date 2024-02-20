using Microsoft.AspNetCore.Mvc;
using RockSeatAuction.API.Entities;
using RockSeatAuction.API.UseCases.Auctions.GetCurrent;

namespace RockSeatAuction.API.Controllers;

public class AuctionController : RocketSeatAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {

        var result = useCase.Execute();


        if (result is null)
              return NoContent(); 

        return Ok(result);
    }
}
