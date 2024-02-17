using Business.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{


    public class EnquireManager : IControlServices
    {
        private IApplicationServices _services;
        public EnquireManager(IApplicationServices applicationServices)
        {
            _services = applicationServices;
        }

        public void CheckOut(Person person)
        {
            if (_services.exist(person))
            {
                Console.WriteLine("Böyle biri var");
            }
            else
            {
                Console.WriteLine("Böyle biri yok");
            }

        }
    }
}
