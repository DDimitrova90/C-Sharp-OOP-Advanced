namespace _03_Ferrari
{
    using System.Text;

    public class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            this.Model = "488-Spider";
            this.Driver = driverName;
        }

        public string Driver { get; private set; }

        public string Model { get; private set; }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}/{this.PushBrakes()}/{this.PushGasPedal()}/{this.Driver}");

            return sb.ToString().Trim();
        }
    }
}
