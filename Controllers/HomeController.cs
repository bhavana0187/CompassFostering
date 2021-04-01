using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CompassFostering.Models;

namespace CompassFostering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public  IActionResult DatabaseOperations(string policyNumber,string policyCode,string policyStatus,int dbOperation)
        {
            Policy policy;
            //policy = new Policy()
            //{
            //    PolicyNumber = Convert.ToInt32(policyNumber),
            //    ProductCode = policyCode,
            //    PolicyStatus = (PolicyStatus)Enum.Parse(typeof(PolicyStatus), policyStatus)
            //};

            if (dbOperation == 1)
            {
                //insert  
                if (policyNumber == "")
                {
                    //We are creating a new entity record                   
                    //_work.PolicyRepo.Insert(policy, _user.UserName(User.Identity.Name));
                    //_work.Save();

                }
            }
            else if (dbOperation == 2)
            {
                //update
                //var pol = await _work.PolicyRepo.GetForUpdate(policyNumber);
                //_work.PolicyRepo.Update(pol, _user.UserName(User.Identity.Name));
                //_work.Save();
            }
            else if (dbOperation == 3)
            {
                //delete                
                //_work.PolicyRepo.Delete(policy, _user.UserName(User.Identity.Name));
                //_work.Save();
            }
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
