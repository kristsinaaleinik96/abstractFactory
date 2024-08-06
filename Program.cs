namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDetailsAbstractFactory factory = new EconomyFactory();
            Vehicle car = new Vehicle(factory);
            car.ShowDetails();
           
        }
    }
}
