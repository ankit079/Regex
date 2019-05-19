namespace RegexExample
{
    public interface IRegularExpression
    {        
        string CleanInput(string strIn);
        bool IsValidEmail(string email);
        void Validate(string[] database, string pattern);
        bool MatchInput(string strIn, string pattern);
    }
}