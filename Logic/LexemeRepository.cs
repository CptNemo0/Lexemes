namespace Logic
{
    public class LexemeRepository
    {
        private List<Lexeme> word_list;

        public LexemeRepository()
        {
            word_list = new();
        }

        public List<Lexeme> Word_list { get => word_list; set => word_list = value; }

        public int Size
        {
            get
            {
                return word_list.Count;
            }
        }

        public void Append(Lexeme lexeme)
        {
            word_list.Add(lexeme);
        }

        public Lexeme Get(int idx)
        {
            return word_list[idx];
        }
    }
}
