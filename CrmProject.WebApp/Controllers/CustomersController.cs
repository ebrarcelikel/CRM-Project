using CrmProject.Models;
using CrmProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrmProject.WebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: HomeController1
        public ActionResult Index()
        {
            var customers = _customerService.List();
            return View(customers);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }
        //public ActionResult FakeInsert()
        //{
        //    CreateCustomerModel model = new CreateCustomerModel
        //    {
        //        Fullname = "John Doe",
        //        IsCorporate = false,
        //        Email = "jhohn@doe.com",
        //        Phone = "876 76",
        //        Explanation = "hjsafg ahsklfhf"
        //    };
        //    _customerService.Create(model);

        //    return RedirectToAction(nameof(Index));

        //}

        // POST: HomeController1/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(CreateCustomerModel model)
        {
            AjaxResponseModel<string> response = new AjaxResponseModel<string>();
            if (ModelState.IsValid)
            {
                _customerService.Create(model);
                response.success = "Customer is added successfully";
                return Json(response);

            }
            foreach (var key in ModelState.Keys)
            {
                var item = ModelState.GetValueOrDefault(key);
                if (item !=null &&item.Errors.Count > 0)
                {
                    item.Errors.ToList().ForEach(err => response.AddError(key, err.ErrorMessage));
                }
            }
            return Json(response);

        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
