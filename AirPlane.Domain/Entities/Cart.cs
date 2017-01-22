using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPlane.Domain.Entities
{
    public class Cart
    {
        public List<CartLine> lineCollection = new List<CartLine>();
        public void AddItem(Aircraft product, int quantity)
        {
            CartLine line = lineCollection.Where(p => p.Product.AircraftID == product.AircraftID).FirstOrDefault();
            if(line == null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Aircraft product)
        {
            lineCollection.RemoveAll(l => l.Product.AircraftID == product.AircraftID);
        }
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Product.EngineCnt * e.Quantity);
        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines { get { return lineCollection; } }
    }
    public class CartLine
    {
        public Aircraft Product { get; set; }
        public int Quantity { get; set; }

    }
}
