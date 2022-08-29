using CrmProject.DataAccess;
using CrmProject.DataAccess.Abstract;
using CrmProject.Entities;
using CrmProject.Models;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CrmProject.Services
{
    public interface ICustomerService
    {
        void Create(string name, string email);
        void Create(CreateCustomerModel model);

        List<Customer> List();
    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public List<Customer> List()

        {
            //create customer 
            return _repository.GetAll();
        }
        public void Create(string name, string email)
        {
            Customer customer = new Customer
            {
                Fullname = name,
                Email = email,
                createdAt = DateTime.Now
            };
            _repository.Add(customer);
        }

        public void Create(CreateCustomerModel model)
        {
            Customer customer = new Customer
            {
                Fullname = model.Fullname,
                Email = model.Email,
                Phone=model.Phone,
                Explanation=model.Explanation,
                Locked=model.Locked,
                IsCorporate=model.IsCorporate,
                createdAt = DateTime.Now
            };
            _repository.Add(customer);
        }
    }
}