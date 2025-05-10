using Bank.Management.Domain.Commands.v1.Deposit.Create;
using Bank.Management.Domain.Commands.v1.Wallet.Create;
using Bank.Management.Infraestructure.Queries.Queries.v1.Wallet;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Management.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/wallet")]
    public class WalletController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WalletController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateWallet([FromBody] CreateWalletCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result.WalletNumber);
        }

        [HttpGet]
        public async Task<IActionResult> GetWalletBalance([FromQuery] GetWalletBalanceCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result.Balance);
        }

        [HttpPost("deposit")]
        public async Task<IActionResult> DepositWallet([FromBody] CreateDepositCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
