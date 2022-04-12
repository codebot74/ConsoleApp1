namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowling bowlingScore = new Bowling();
            bowlingScore.CalculateScore();
            Console.WriteLine("Score Is: " + bowlingScore.Score); // 0
            bowlingScore.RegisterThrows(10, 10); // second will be ignored
            bowlingScore.RegisterThrows(10, 10); // 3rd will be ignored
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10);
            bowlingScore.RegisterThrows(10, 10, 10);
            bowlingScore.CalculateScore();
            Console.WriteLine("Score Is: " + bowlingScore.Score); // Final Score
            Console.ReadLine();

        }
    }
}