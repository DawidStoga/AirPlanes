using AirPlane.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new EFStudentRepository();
            var sts = st.Students.Where(x => x.Address != null);
            foreach (var s in sts)
            {
                Console.Write(s.Address.Address1);

            }
        }
    }
}
