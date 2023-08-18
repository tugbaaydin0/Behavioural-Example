using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal abstract class Tablet
    {
       public string Brand { get; set; }
       public string Model { get; set; }

        public Tablet(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public abstract void Accept(IVisitor visitor);
   
    }
}
