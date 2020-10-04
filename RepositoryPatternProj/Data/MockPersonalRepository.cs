using RepositoryPatternProj.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternProj.Data
{
    class MockPersonalRepository : IRepository<Personal>
    {
        public Personal Delete()
        {
            //You can use Delete method here. i will not do something but you can.. -Alper
            return null;
        }

        public IEnumerable<Personal> GetAll()
        {
            List<Personal> personals = new List<Personal>
            {
                new Personal
                {
                    id = 1,
                    NameorTag = "Hasan Cem",
                    PhoneNumber = "546 765 44 32",
                    Salary = 5650
                }
            };
            return personals;
        }

        public Personal GetById(int id)
        {
            //You can use GetById method here. i will not do something but you can.. -Alper
            return null;
            
        }

        public Personal Update()
        {
            //You can use Update method here. i will not do something but you can.. -Alper
            return null;
        }
    }
}
