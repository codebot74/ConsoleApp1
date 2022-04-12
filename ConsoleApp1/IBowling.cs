namespace ConsoleApp1
{
    public interface IBowling
    {
        void RegisterThrows(params int[] throws);
        void CalculateScore();
    }
}
