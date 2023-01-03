namespace experiment.Models
{
    public class Log
    {
        public int Id { get; set; }
        public int SensorId { get; set; }

        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}
