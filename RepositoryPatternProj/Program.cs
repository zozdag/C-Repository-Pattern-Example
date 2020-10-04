using RepositoryPatternProj.Data;
using System;

namespace RepositoryPatternProj
{
    class Program
    {
        static void Main(string[] args)
        {
            MockCustomerRepository customer = new MockCustomerRepository();
            MockPersonalRepository staff = new MockPersonalRepository();

            foreach(var k in staff.GetAll())
            {
                Console.WriteLine("Personal id : " + k.id + " Personal Name : " + k.NameorTag);
            }

          // you can repeat for customer. it is same as above
        }
    }
}
