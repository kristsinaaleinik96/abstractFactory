namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory economyFactory = new EconomyVehicleFactory();
            IVehicleFactory standartFactory = new StandartVehicleFactory();
            IVehicleFactory extraFactory = new ExtraVehicleFactory();

            IVehicle economyVehicle = new EconomyVehicle();
            IVehicle standartVehicle = new StandartVehicle();
            IVehicle extraVehicle = new ExtraVehicle();
        }
    }
}
