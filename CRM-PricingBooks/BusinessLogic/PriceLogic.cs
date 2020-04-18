using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM_PricingBooks.DTOModels;
using CRM_PricingBooks.Database;
using CRM_PricingBooks.Database.Models;

namespace CRM_PricingBooks.BusinessLogic
{
    public class PriceLogic : IPriceLogic
    {
        private readonly IProductTableDB _productTableDB;

        public PriceLogic(IProductTableDB productTableDB)
        {
            _productTableDB = productTableDB;
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public List<PriceDTO> GetPriceProducts()
        {
            // Retrieve all Products from database
            List<Product> allProducts = _productTableDB.GetAll();

            List<PriceDTO> priceLists = GetPrice();

        }

        private List<PriceDTO> GetPrice() //Creating empty prices lists.
        {
            List<PriceDTO> emptyPriceLists = new List<PriceDTO>()
            {
                new PriceDTO() {GroupName="Price List 2020", Description="Books from Asia",  Products=new List<ProductDTO>()},
                new PriceDTO() {GroupName="Price List 2021", Description="Thriller Books",  Products=new List<ProductDTO>()},
            };
            return emptyPricelists;
        }

        private void calculatediscount(String activeCampaign, Product product ) //Calculating discounts
        {
          if(activeCampaign == "XMAS")
          {
            product.PromotionPrice= (product.Price)-(product.Price)*(0.05);
          }
          if(activeCampaign == "SUMMER")
          {
            product.PromotionPrice= (product.Price)-(product.Price)*(0.20);
          }
          if(activeCampaign == "BFRIDAY")
          {
            product.PromotionPrice= (product.Price)-(product.Price)*(0.25);
          }
          else
          {
            product.PromotionPrice = product.Price;
          }

        }



    }
}
