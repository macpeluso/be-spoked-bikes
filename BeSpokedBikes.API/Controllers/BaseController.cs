using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BeSpokedBikes.API.Controllers
{


    public class BaseController : Controller
    {
        private IMediator mediator;

        protected IMediator Mediator => this.mediator ?? (this.mediator = this.HttpContext.RequestServices.GetService<IMediator>());
    }
}
