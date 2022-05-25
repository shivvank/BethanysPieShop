using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class HomeController:Controller
    {
        private readonly IPieRepository _pieRespository;
        public HomeController(IPieRepository pieRepository)
        {
            _pieRespository = pieRepository;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.PiesOfTheWeek = _pieRespository.PiesOfTheWeek;
            return View(homeViewModel);
        }
    }
}
