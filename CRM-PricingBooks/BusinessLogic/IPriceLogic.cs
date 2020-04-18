using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_PricingBooks.DTOModels;

namespace CRM_PricingBooks.BusinessLogic
{

    public interface IPriceProduct
    {
        public List<PriceDTO> GetPriceProducts();
    }
}
