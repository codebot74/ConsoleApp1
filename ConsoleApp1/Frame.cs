namespace ConsoleApp1
{
    public class Frame : IFrame
    {
        private int[] throws;

        public int FrameNumber { get; set; }
        public bool Strike { get; set; }
        public bool Spare { get; set; }
        public bool LastFrame { get; set; }

        public int[] Throws { get => throws; set => throws = value; }


        public bool IsSpare()
        {
            return this.Throws.Take(2).Sum() == 10;
        }

        public bool IsStrike()
        {
            return this.Throws.First() == 10;
        }

        public bool IsLastFrame()
        {
            return this.FrameNumber == 10;
        }

    }
}
