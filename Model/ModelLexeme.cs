using System.ComponentModel;
using Logic;

namespace Model
{
    // All the code in this file is included in all platforms.
    public class ModelLexeme
    {
        private string word;
        private string definition;

        public ModelLexeme(string word, string definition)
        {
            this.word = word;
            this.definition = definition;
        }

        public ModelLexeme()
        {
            this.word = String.Empty;
            this.definition = String.Empty;
        }

        public void Update(Object s, PropertyChangedEventArgs e)
        {
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Word { get => word; set { word = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Word))); } }
        public string Definition { get => definition; set { definition = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Definition))); } }
    }
}
