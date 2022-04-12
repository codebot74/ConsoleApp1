namespace ConsoleApp1
{
    public class Bowling : IBowling
    {
        private readonly List<int> maxThrows = new List<int>();
        readonly List<Frame> frames = new List<Frame>();
        private int frameNumber = 0;
        public int Score { get; private set; }

        public void RegisterThrows(params int[] throws)
        {

            var validThrows = GetValidThrows(throws);
            frameNumber++;
            Frame initialFrame = new Frame { Throws = validThrows, FrameNumber = frameNumber };
            if (initialFrame.IsStrike() && !initialFrame.IsLastFrame())
            {
                frames.Add(new Frame { Strike = true, Throws = validThrows.Take(1).ToArray(), FrameNumber = frameNumber });
            }
            else if (initialFrame.IsSpare() && !initialFrame.IsLastFrame())
            {
                frames.Add(new Frame { Spare = true, Throws = validThrows.Take(2).ToArray(), FrameNumber = frameNumber });
            }
            else if (initialFrame.IsLastFrame())
            {
                frames.Add(new Frame { LastFrame = true, Throws = validThrows.Take(3).ToArray(), FrameNumber = frameNumber });
            }
            else
            {
                frames.Add(new Frame { Throws = validThrows.Take(2).ToArray(), FrameNumber = frameNumber });
            }
        }

        private int[] GetValidThrows(params int[] throws)
        {
            int[] finalThrows = new int[3];
            if (throws.Length == 0)
            {
                finalThrows[0] = 0;
                finalThrows[1] = 0;
                finalThrows[2] = 0;
            }
            else if (throws.Length == 1)
            {
                finalThrows[0] = throws[0];
                finalThrows[1] = 0;
                finalThrows[2] = 0;
            }
            else if (throws.Length == 2)
            {
                finalThrows[0] = throws[0];
                finalThrows[1] = throws[1];
                finalThrows[2] = 0;
            }
            else
            {
                finalThrows[0] = throws[0];
                finalThrows[1] = throws[1];
                finalThrows[2] = throws[2];
            }

            return finalThrows;
        }

        public void CalculateScore()
        {
            int score = 0;
            foreach (var currentFrame in frames)
            {
                maxThrows.AddRange(currentFrame.Throws);
            }

            var frame = 1;
            var frameStart = 0;
            var maxFrame = 10;

            while (maxThrows.Count <= 21 && maxFrame == frames.Count && frame <= frames.Count)
            {
                if (maxThrows[frameStart] == 10)
                {
                    // Is strike
                    score += 10 + maxThrows[frameStart + 1] + maxThrows[frameStart + 2];
                    frameStart += 1;
                }
                else if (maxThrows[frameStart] + maxThrows[frameStart + 1] == 10)
                {
                    // Is spare
                    score += 10 + maxThrows[frameStart + 2];
                    frameStart += 2;
                }
                else
                {
                    score += maxThrows[frameStart] + maxThrows[frameStart + 1];
                    frameStart += 2;
                }
                frame++;
            }

            this.Score = score;
        }
    }

}
