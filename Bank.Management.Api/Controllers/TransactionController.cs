using Bank.Management.Domain.Commands.v1.Transactions.Create;
using Bank.Management.Infraestructure.Queries.Queries.v1.Transaction;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Management.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/transaction")]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransaction([FromBody] CreateTransactionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetTransaction([FromQuery] GetTransactionsCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
