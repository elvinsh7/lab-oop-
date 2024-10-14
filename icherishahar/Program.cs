using icherishahar;

namespace icherishahar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car automobile = new Car("BMW", "e39", 50, 0.14, 5, "green", 2022);
            Car automobile1 = new Car("Mercedes", "CLS", 62, 0.17, 14, "white", 2020);
            Car automobile2 = new Car("Audi", "A7", 60, 0.15, 6, "black", 2012);

            automobile.ShowInfo();
            automobile.Drive(12);

            automobile1.ShowInfo();
            automobile1.Drive(60);

            automobile2.ShowInfo();
            automobile2.Drive(24);

        }
    }

}
