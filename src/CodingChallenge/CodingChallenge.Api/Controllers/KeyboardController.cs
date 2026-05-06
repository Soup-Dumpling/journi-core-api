using Journi.CodingChallenge.Api.Models.Keyboard;
using Journi.CodingChallenge.Core.Models.DTOs;
using Journi.CodingChallenge.Core.UseCases.Keyboard.CreateKeyboard;
using Journi.CodingChallenge.Core.UseCases.Keyboard.DeleteKeyboard;
using Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboard;
using Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboards;
using Journi.CodingChallenge.Core.UseCases.Keyboard.UpdateKeyboard;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Api.Controllers
{
    [ApiController]
    [Route("api/keyboards")]
    public class KeyboardController : ControllerBase
    {
        private readonly ILogger<KeyboardController> logger;
        private readonly IMediator mediator;

        public KeyboardController(ILogger<KeyboardController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task CreateKeyboard([FromBody] CreateKeyboardRequest model)
        {
            var request = new CreateKeyboardCommand(model.Name, model.Description, model.Price, model.ImageFileName, model.Wireless, model.Weight, model.ReleaseDate, model.IsMechanical);
            await mediator.Send(request);
        }

        [HttpGet("{id}")]
        public async Task<Core.Models.Entities.Keyboard> GetKeyboard([FromRoute] Guid id)
        {
            var query = new GetKeyboardQuery(id);
            var response = await mediator.Send(query);
            return response;
        }

        [HttpGet]
        public async Task<PagedResult<GetKeyboardsQueryDTO>> GetKeyboards([FromQuery] GetKeyboardsRequest model)
        {
            var query = new GetKeyboardsQuery(model.PageSize, model.Page, model.Name, model.Wireless, model.IsMechanical);
            var response = await mediator.Send(query);
            return response;
        }

        [HttpPut]
        public async Task UpdateKeyboardDetails([FromBody] UpdateKeyboardRequest model)
        {
            var request = new UpdateKeyboardCommand(model.Id, model.Name, model.Description, model.Price, model.ImageFileName, model.Wireless, model.Weight, model.ReleaseDate, model.IsMechanical);
            await mediator.Send(request);
        }

        [HttpDelete("{id}")]
        public async Task DeleteKeyboard([FromRoute] Guid id)
        {
            var request = new DeleteKeyboardCommand(id);
            await mediator.Send(request);
        }
    }
}
