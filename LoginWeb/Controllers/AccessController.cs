using LoginWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace LoginWeb.Controllers
{
    public class AccessController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {

            if (ModelState.IsValid == true)
            {

                if (model.Username == "User" && model.Password == "Pa$$W0rd")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    ViewBag.Message = "Invalid UserName or password";
                    return View(model);
                }
                ModelState.AddModelError("", "Invalid username/ password.");
            }
            return View(model);
        }

    }
}