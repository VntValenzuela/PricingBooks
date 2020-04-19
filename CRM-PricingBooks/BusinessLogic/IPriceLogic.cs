using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_PricingBooks.DTOModels; //Aun falta los DTOModels, suponiendo que ya estan creados

namespace CRM_PricingBooks.BusinessLogic
{

    public interface IPriceLogic
    {
        public List<PriceDTO> GetPriceProducts();
        public List<GroupPricesListDTO> GetGroupPrices();

    }
}
