using AirPlane.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPlane.Domain.Entities;
using System.IO;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace AirPlane.Domain.Concrete
{
   public class EFAirPlaneRepostory :IAirPlaneRepository
    {
     
        public EFAirPlaneRepostory()
        {
           
          
          context = new EFDbContext();
            context.Database.Log = (message) =>
            { 
                StreamWriter sw = new FileInfo("D:\\file.txt").AppendText();
              
                sw.Write("EF Message: {0} ", message);
                sw.Close();
                
            };
        }
        private EFDbContext context;
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
            //  Aircraft dbEntry = context.AirCrafts.Find(productID);  Find search sin entity first
            var dbEntry = context.AirCrafts.Include("FullImage").Where(a => a.AircraftID == productID).FirstOrDefault();

            if (dbEntry != null)
            {
              //  dbEntry.FullImage.PhotoFullImageId = null;

                context.AirCrafts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
