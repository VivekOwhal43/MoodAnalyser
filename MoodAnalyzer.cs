namespace MoodAnalyser
{
    public class MoodAnalzser
    {
        public string AnalyseMood(string msg)
        {
            if(msg.ToLower().Contains("sad"))
            {
                return "You are SAD";
            }
            else
            {
                return "You are HAPPPY";
            }
        }
    }
}