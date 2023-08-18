using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class ThreeGVisitor : IVisitor
    {
                
            public void Visit(Tablet tablet)
            {
                if (tablet is IPad)
                {
                    Console.WriteLine("ıpad wifi 3g özelliği yok ");
                }
                else if (tablet is GalaxyTab)
                {
                    Console.WriteLine("galaxytab 3g özelliği açıldı");
                }
                else
                    Console.WriteLine("bu nesne bir tablet değil");
            }
        
    }
}
