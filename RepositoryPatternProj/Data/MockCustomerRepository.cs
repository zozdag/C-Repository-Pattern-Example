using RepositoryPatternProj.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternProj.Data
{
    class MockCustomerRepository : IRepository<Customer>
    {
        public Customer Delete()
        {
            //You can use Delete method here. i will not do something but you can.. -Alper
            return null;
        }

        public IEnumerable<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    id = 1,
                    NameorTag = "Hasan Cem",
                    ContactTel = "54352352"
                }
            };
            return customers;
        }

        public Customer GetById(int id)
        {
            //You can use Delete method here. i will not do something but you can.. -Alper
            return null;
        }

        public Customer Update()
        {
            //You can use Delete method here. i will not do something but you can.. -Alper
            return null;
        }
    }
}
