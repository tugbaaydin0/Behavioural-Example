namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPad iPad = new IPad("Ipad mini", "Apple");
            GalaxyTab galaxyTab = new GalaxyTab("GalaxyTab", "Samsung");

            iPad.Accept(new WifiVisitor());
            galaxyTab.Accept(new WifiVisitor());

            iPad.Accept(new ThreeGVisitor());
            galaxyTab.Accept(new ThreeGVisitor());
        }
    }
}