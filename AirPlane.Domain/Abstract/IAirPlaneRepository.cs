using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPlane.Domain.Entities;
namespace AirPlane.Domain.Abstract
{
   
    public interface IAirPlaneRepository
    {
        IEnumerable<Aircraft> AirCrafts { get; }
        void SaveProduct(Aircraft product);
        Aircraft DeleteProduct(int productID);
    }
    public interface IStudentRepository
    {
        IEnumerable<Student> Students { get; }
    }
}
