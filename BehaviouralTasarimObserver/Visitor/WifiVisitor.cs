using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class WifiVisitor : IVisitor
    {
       

        public void Visit(Tablet tablet)
        {
            if(tablet is IPad)
            {
                Console.WriteLine("ıpad wifi açıldı");
            }
            else if(tablet is GalaxyTab)
            {
                Console.WriteLine("galaxytab wifi özelliği yok");
            }
            else 
                Console.WriteLine("bu nesne bir tablet değil");
        }
    }
}
