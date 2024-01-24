using System.ComponentModel;

namespace Logic
{
    public class Lexeme : INotifyPropertyChanged
    {
        private string word;
        private string definition;

        public Lexeme(string word, string definition)
        {
            this.word = word;
            this.definition = definition;
        }

        public Lexeme()
        {
            this.word = String.Empty;
            this.definition = String.Empty;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Word { get => word; set { word = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Word))); } }
        public string Definition { get => definition; set { definition = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Definition))); } }
    }
}
