namespace testGoos.Models
{
    public class HangmanViewModel
    {
        public int Tries { get; set; }
        public int Length { get; set; }
        public string Used { get; set; }
        public string Discovered { get; set; }
    }
}