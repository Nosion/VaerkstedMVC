
using Repository.Abstract;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{

    public class CustomerController : Controller
    {

        IGenericRepository<Customer> repository;
        public CustomerController(IGenericRepository<Customer> customerRepos)
        {
            this.repository = customerRepos;
        }



        public ViewResult GetCustomerData(string searchStr)
        {

            IEnumerable<Customer> customerData = repository.GetAll();

            if (!String.IsNullOrEmpty(searchStr))
            {
                customerData = repository.GetAll().Where(c => c.Name.ToLower().Contains(searchStr.ToLower()) || c.Company.Contains(searchStr.ToLower()));
            }
            return View(customerData);
        }

        public ViewResult GetCustomerDetails(int customerId = 1)
        {
            Customer customerDetails;
            customerDetails = repository.GetById(customerId);
           
            return View(customerDetails);
        }

        public ViewResult EditCustomerDetails(int customerId = 1)
        {
            Customer EditCustomer;

            EditCustomer = repository.GetById(customerId);

            return View(EditCustomer);
        }

        [HttpPost]
        public ActionResult EditCustomerDetails(Customer customer)
        {

            Customer EditCustomer = repository.GetById(customer.Id);
            
            if (ModelState.IsValid)
            {
                EditCustomer.Name = customer.Name;
                EditCustomer.Company = customer.Company;
                EditCustomer.Phone = customer.Phone;

                repository.Edit(EditCustomer);

                return View("GetCustomerDetails", EditCustomer);
            }
            return View(customer);
        }

        public ViewResult CreateNewCustomer()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewCustomer(Customer customer)
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = customer.Name;
            newCustomer.Company = customer.Company;
            newCustomer.Phone = customer.Phone;
            repository.Insert(newCustomer);

            return View("GetCustomerDetails", newCustomer);

        }



        //    public class CustomerController : Controller
        //    {
        //     IGenericRepository<Customer> repository;
        //     public CustomerController(IGenericRepository<Customer> customerRepos)
        //     {
        //         this.repository = customerRepos;
        //     }


        //        // GET: Customer
        //        public ActionResult Index()
        //        {
        //            return View(repository.GetAll());
        //        }
    }
}