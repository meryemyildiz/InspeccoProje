using BusinessLayer.Abstract;
using EntityLayer.Models;
using EntityLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspeccoUI.Controllers
{
    public class CompanyController : Controller
    {
        ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //List<CompanyViewModel> result = new List<CompanyViewModel>();
            var result = (_companyService.GetAllCompany()).Data;
            return View(result);
        }
    }
}
