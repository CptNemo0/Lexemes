namespace Logic
{
    public interface ILogic
    {
        public Lexeme Current_Lexeme { get; }
        public void Init();
        public void NextLexeme();
    }
}
