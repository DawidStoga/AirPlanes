using AirPlane.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPlane.Domain.Entities;

namespace AirPlane.Domain.Concrete
{
   public class EFStudentRepository :IStudentRepository
    {
        private EFDbContext context = new EFDbContext();
       

        public IEnumerable<Student> Students
        {
            get
            {
                return context.Students;
            }
        }
    }
}
