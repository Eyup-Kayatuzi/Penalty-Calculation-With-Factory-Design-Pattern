using Microsoft.AspNetCore.Mvc;
using PenaltyCalculationApp.Datas.Repository.Interface;
using PenaltyCalculationApp.Models;
using PenaltyCalculationApp.Services.Abstract;
using PenaltyCalculationApp.ViewModels;
using System.Diagnostics;

namespace PenaltyCalculationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IHolidayRepository _holidayRepository;
        private readonly IPenaltyCalculationProcessor _penaltyCalculationProcessor;

        public HomeController(ICountryRepository countryRepository, IHolidayRepository holidayRepository, IPenaltyCalculationProcessor penaltyCalculationProcessor)
        {
            _countryRepository = countryRepository;
            _holidayRepository = holidayRepository;
            _penaltyCalculationProcessor = penaltyCalculationProcessor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            setDropDownListForCountry();

            ViewBag.ShowResult = false;

            return View();
        }

        [HttpPost]
        public IActionResult Index(PenaltyInputVM model)
        {
            setDropDownListForCountry(); // it is neccesry for vievBag of coutry list in index.cshtml
            var _country = _countryRepository.GetCountryById(model.Country.Id);
            var hh = _country != null ? (_holidayRepository.GetAllBySomeCountryId(_country.Id)) : null;
            model.dateTimes22 = hh != null ? hh.Select(h => h.Date).ToList(): null;

            model.Country = _country;
            var item = _penaltyCalculationProcessor.Process(model);

            if (item != null)
            {
                ViewBag.BusinessDays = item.BusinessDays;
                ViewBag.Penalty = item.TotalPenaltyPrice;
                ViewBag.CurrencySymbol = item.ForCurrency;
                ViewBag.ShowResult = true;
            }
            return View(model);
        }

        private void setDropDownListForCountry()
        {
            var _countryList = _countryRepository.GetAll.ToList();
            ViewBag.countryList = _countryList;
        }
    }
}