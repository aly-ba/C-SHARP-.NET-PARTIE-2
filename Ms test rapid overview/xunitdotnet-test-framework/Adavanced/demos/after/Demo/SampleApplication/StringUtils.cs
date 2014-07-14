namespace SampleApplication
{
    public class StringUtils
    {
        public string MakeUpper(string s)
        {
            return s.ToUpper();
        }

        public string AppendNumberToString(string s, int num)
        {
            return s + num;
        }
    }
}