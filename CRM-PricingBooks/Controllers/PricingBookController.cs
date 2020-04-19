﻿using CRM_PricingBooks.BusinessLogic;
using CRM_PricingBooks.Controllers.DTOModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_PricingBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingBookController : ControllerBase
    {
        private readonly IPriceLogic _priceLogic;

        public PricingBookController(IPriceLogic pricelogic)
        {
            _priceLogic = pricelogic;
        }

        [HttpGet]
        public IEnumerable<PricingBookDTO> GetAll()
        {
            return _priceLogic.GetPriceProducts();
        }
    }
}
