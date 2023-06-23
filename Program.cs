namespace MoodAnalyser
{
    public class Program
    {
        public static string Happy_Mood = "I am In happy Mood";
        public static string Sad_Mood = "I am In Sad Mood";

        public static void Main(string[] args)
        {
            Mood obj = new Mood();
            obj.AnalyseMood(Happy_Mood);
            obj.AnalyseMood(Sad_Mood);
        }
    }
}