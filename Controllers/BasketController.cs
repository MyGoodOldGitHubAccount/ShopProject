﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopProject.Data;
using ShopProject.Models;
namespace ShopProject.Controllers
{
    public class BasketController : Controller
    {
        
        UnitOfWork unit;
        

        public BasketController(UnitOfWork unit)
        {
            this.unit = unit;

        }


        public async Task<IActionResult> Index()
        {
            
            Basket basket = await unit.BasketRepository.GetByUserId(unit.CurrentUser.Id);
            if (basket == null)
            {
                basket = await unit.BasketRepository.Add(new Basket
                {
                    UserId = unit.CurrentUser.Id,
                });
            }
            BasketViewModel model = await GetBasketViewModelAsync(basket);
            return View(model);
        }

        public async Task<IActionResult> Delete(int goodid)
        {
            var basket = await unit.BasketRepository.GetByUserId(unit.CurrentUser.Id);
            var goodinbasket = await unit.GoodInBasketRepository.GetByGoodAndBasketId(goodid,(int)basket.Id);
            await unit.GoodInBasketRepository.Delete(goodinbasket.Id);
            
            basket.AmountOfGood--;
            basket.TotalSum -= (decimal)goodinbasket.Amount * goodinbasket.Good.Price;
            unit.Save();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Show(int basket_id)
        {
            var basket = await unit.BasketRepository.GetFromOrder(basket_id);
            if(basket != null){
                BasketViewModel model = await GetBasketViewModelAsync(basket);
                return View(model);
            }
            return BadRequest("Basket with that id doesn't exist");
        }

       public async Task<BasketViewModel> GetBasketViewModelAsync(Basket basket)
        {
            BasketViewModel model = new BasketViewModel();
            model.CanBuy = true;
            var goodsinbasket = unit.GoodInBasketRepository.GetAllByBasketId((int)basket.Id);
            model.TotalSum = (decimal)basket.TotalSum;
            model.UserId = unit.CurrentUser.Id;

            foreach (var goodinbasket in goodsinbasket.ToList())
            {
                model.GoodId.Add(goodinbasket.GoodId);
                model.GoodNames.Add(goodinbasket.Good.Name);
                model.GoodPrices.Add(goodinbasket.Good.Price);
                model.GoodAmounts.Add(goodinbasket.Amount);
                model.SumOfGoods.Add(goodinbasket.SumOfGoods);
                var goodatbasket = await unit.GoodAtStockRepository.GetByGoodId(goodinbasket.GoodId);
                if (goodatbasket.AmountLeft < goodinbasket.Amount)
                {
                    model.IsAvailable.Add(false);
                    model.CanBuy = false;
                }
                else
                {
                    model.IsAvailable.Add(true);
                }


            }
            model.AmountOfGoods = (int)basket.AmountOfGood;
            return model;

        }

        public async Task<IActionResult> Plus(int goodid)
        {

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Minus(int goodid)
        {
            return RedirectToAction("Index");
        }
    }
}
