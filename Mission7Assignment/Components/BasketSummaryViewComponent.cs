using Microsoft.AspNetCore.Mvc;
using Mission7Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7Assignment.Components
{
    public class BasketSummaryViewComponent : ViewComponent 
    {
        private Basket basket;
        public BasketSummaryViewComponent(Basket basketservice)
        {
            basket = basketservice;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
