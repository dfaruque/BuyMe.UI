﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BuyMe.UI.Areas.Config.Controllers
{
    [Area("Config")]
    public class BaseController : Controller
    {
        protected IMediator Mediator => HttpContext.RequestServices.GetService<IMediator>();
    }
}