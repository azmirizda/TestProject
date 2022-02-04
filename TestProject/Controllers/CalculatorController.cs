using Microsoft.AspNetCore.Mvc;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            Calculator Model = new Calculator();
            return View(Model);
        }

        [HttpPost]
        public IActionResult Add(Calculator model)
        {
            model.Result = model.FirstNumber + model.SecondNumber;
            return View("Index",model);
        }

        [HttpPost]
        public IActionResult Substract(Calculator model)
        {
            model.Result = model.FirstNumber - model.SecondNumber;
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Divide(Calculator model)
        {
            model.Result = model.FirstNumber / model.SecondNumber;
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Multiply(Calculator model)
        {
            model.Result = model.FirstNumber * model.SecondNumber;
            return View("Index", model);
        }
    }
}
