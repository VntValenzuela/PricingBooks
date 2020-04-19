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
        private readonly IPricingBookDB _productTableDB;

        public PriceLogic(IPricingBookDB productTableDB)
        {
            _productTableDB = productTableDB;
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public List<PriceDTO> GetPriceProducts()
        {
            // Retrieve all Products from database
            List<PricingBook> allProducts = _productTableDB.GetAll();

            List<PriceDTO> priceLists = GetPrice();

        }
        public List<GroupPricesListDTO> GetGroupPrices() {

            List<ProductPrice> allProducts = _productTableDB.GetAll();
            List<GroupPricesListDTO> pricesLists = GetEmptyGroups();

            foreach (PricingBook price in allProducts) {

                assignPriceList(price,allProducts);
            }
            return pricesLists;
        }

        //Empty Lists from "Prices List"
        private List<GroupPricesDTO> GetEmptyGroups() {

            List<GroupPricesDTO> emptyPricelists = new List<GroupPricesDTO>()
            {
                new GroupPricesDTO() {GroupName="Price List 2019", Description="Basketball and Soccer Balls",  Products=new List<ProductDTO>()},
                new GroupPricesDTO() {GroupName="Price List 2018", Description="Thriller Books",  Products=new List<ProductDTO>()},
            };
            return emptyPricelists;

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


        private void assignPriceList(ProductPrice priceproduct, List<GroupPricesDTO> groupstoAssign) {

            groupToAssignProductPrice.Add(new GroupPricesDTO() { ProductCode = priceproduct.ProductCode, FixedPrice =priceproduct.FixedPrice });

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
