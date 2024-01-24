namespace Logic
{
    public class LogicManager : ILogic
    {
        private Lexeme current_lexeme;
        private LexemeRepository repository;

        public Lexeme Current_Lexeme
        {
            get
            {
                return current_lexeme;
            }
        }

        public String Word
        {
            get
            {
                return current_lexeme.Word;
            }
        }

        public String Definition
        {
            get
            {
                return current_lexeme.Definition;
            }
        }

        public LogicManager()
        {
            current_lexeme = new();
            repository = new();
        }

        public async void Init()
        {
            if (repository != null)
            {
                await Loader.LoadAsync(repository);
            }
        }

        public void NextLexeme()
        {
            Random random = new();
            int idx = random.Next(0, repository.Size);
            current_lexeme.Word = repository.Word_list[idx].Word;
            current_lexeme.Definition = repository.Word_list[idx].Definition;
        }
    }
}
