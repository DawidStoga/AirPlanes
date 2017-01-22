using AirPlane.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPlane.Domain.Entities;

namespace AirPlane.Domain.Concrete
{
   public class EFAirPlaneRepostory :IAirPlaneRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Aircraft> AirCrafts
        {
            get
            {
              var y =   context.AirLines.Select(x => x.Name);

               // return new List<Aircraft> { new Aircraft { Description = "lll" } };
                return context.AirCrafts;
            }
        }

        public void SaveProduct(Aircraft product)
        {
            if (product.AircraftID == 0)
            {
                context.AirCrafts.Add(product);
            }
            else
            {
               

                var dbEntry = context.AirCrafts.Find(product.AircraftID);
                dbEntry.Category = product.Category;
                dbEntry.Description = product.Description;
                dbEntry.EngineCnt = product.EngineCnt;
                var updatedImage = dbEntry.FullImage ?? new PhotoFullImage(); //todo null exception
                
                if(product.FullImage!= null)
                updatedImage.HighResolutionBits = product.FullImage.HighResolutionBits; //todo//what if null
                dbEntry.ImageURl = product.ImageURl;
                dbEntry.Name = product.Name;
                dbEntry.ThumbnailBits = product.ThumbnailBits;
                dbEntry.Type = product.Type;
                dbEntry.FullImage = updatedImage;
            }
            
            context.SaveChanges();
        }
        public Aircraft DeleteProduct(int productID)
        {
            Aircraft dbEntry = context.AirCrafts.Find(productID);
            if (dbEntry != null)
            {
                context.AirCrafts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
