namespace experiment.Models
{
    public class Dimension
    {
        public int Id { get; set; }
        public int SensorId { get; set; }

        public double Temerature { get; set; }

        public DateTime Time { get; set; }
    }
}
