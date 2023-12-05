using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {

        /*
         * Katmanlı mimaride nasıl controller katmanına IBrandService _brandService diye bir service enjeksiyonu yapıyorsak burada ise IMediatR enjeksiyonu
         * yapıyoruz çünkü CQRS pattern'ı MediatR ile kullanıyoruz ve Handle metodunu MediatR ile tetikliyoruz. Katmanlı mimarideki _brandService.Add() metodu
         * gibi düşünülebilir.
        */

        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator? _mediator;

    }
}
