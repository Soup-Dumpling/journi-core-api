using Journi.CodingChallenge.Api.Models.Headphone;
using Journi.CodingChallenge.Core.Models.DTOs;
using Journi.CodingChallenge.Core.UseCases.Headphone.CreateHeadphone;
using Journi.CodingChallenge.Core.UseCases.Headphone.DeleteHeadphone;
using Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphone;
using Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphones;
using Journi.CodingChallenge.Core.UseCases.Headphone.UpdateHeadphone;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Api.Controllers
{
    [ApiController]
    [Route("api/headphones")]
    public class HeadphoneController : ControllerBase
    {
        private readonly ILogger<HeadphoneController> logger;
        private readonly IMediator mediator;

        public HeadphoneController(ILogger<HeadphoneController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<Guid> CreateHeadphone([FromBody] CreateHeadphoneRequest model)
        {
            var request = new CreateHeadphoneCommand(model.BatteryLife, model.Color, model.Description, model.ImageFileName, model.Manufacturer, model.Mic, model.Name, model.NoiseCancellationType, model.Price, model.ReleaseDate, model.Type, model.Weight, model.Wireless);
            var response = await mediator.Send(request);
            return response;
        }

        [HttpGet("{id}")]
        public async Task<Core.Models.Entities.Headphone> GetHeadphone([FromRoute] Guid id)
        {
            var query = new GetHeadphoneQuery(id);
            var response = await mediator.Send(query);
            return response;
        }

        [HttpGet]
        public async Task<PagedResult<GetHeadphonesQueryDTO>> GetHeadphones([FromQuery] GetHeadphonesRequest model)
        {
            var query = new GetHeadphonesQuery(model.PageSize, model.Page, model.Name, model.Manufacturer, model.Color, model.Wireless, model.Mic);
            var resposne = await mediator.Send(query);
            return resposne;
        }

        [HttpPut]
        public async Task UpdateHeadphoneDetails([FromBody] UpdateHeadphoneRequest model)
        {
            var request = new UpdateHeadphoneCommand(model.Id, model.BatteryLife, model.Color, model.Description, model.ImageFileName, model.Manufacturer, model.Mic, model.Name, model.NoiseCancellationType, model.Price, model.ReleaseDate, model.Type, model.Weight, model.Wireless);
            await mediator.Send(request);
        }

        [HttpDelete("{id}")]
        public async Task DeleteHeadphone([FromRoute] Guid id)
        {
            var request = new DeleteHeadphoneCommand(id);
            await mediator.Send(request);
        }
    }
}
