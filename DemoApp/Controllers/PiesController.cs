using DemoApp.Models;
using DemoApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class PiesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPieRepository _pieRepository;

        public PiesController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }

        public ViewResult List()
        {
            var pieListViewModel = new PiesListViewModel
            {
                Pies = _pieRepository.Pies,
                CurrentCategory = "Cheese Cake"
            };
            return View(pieListViewModel);
        }
    }
}
