namespace QuantumMvc.Models
{
    public class QuantumState
    {
        public double State0Amplitude { get; set; }
        public double State1Amplitude { get; set; }
        public double Probability0 { get; set; }
        public double Probability1 { get; set; }
        public string? MeasuredState { get; set; }
    }
}
