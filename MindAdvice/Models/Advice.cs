namespace MindAdvice.Models
{

    public class Advice
    {
        public Slip slip { get; set; }
    }

    public class Slip
    {
        public int id { get; set; }
        public string advice { get; set; }
    }

}
