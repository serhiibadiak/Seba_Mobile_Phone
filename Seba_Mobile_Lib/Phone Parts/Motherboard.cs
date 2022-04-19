namespace SebaMobileLib
{
    public class Motherboard
    {
        public Processor Processor { get; set; }
        public TelecomModule TelecomModule { get; set; }
        public int RAM { get; set; }
        public int ROM { get; set; }
        public string[] SIMStandart { get; set; }
        public int SIMCount { get; set; }
        public string OS { get; set; }
        public bool MemoryCardSupport { get; set; }
        public int MemoryCardSize { get; set; }
        public override string ToString()
        {
            return "Motherboard";
        }
    }
}
