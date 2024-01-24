using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ViewModel
{
    public class ViewManager : INotifyPropertyChanged
    {
        private ILogic logic;
        private String word;
        private String definition;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Command Next { get; set; }
        public string Word { get => word;  set { word = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Word))); } }
        public string Definition { get => definition; set { definition = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Definition))); } }

        public ViewManager()
        {
            word = String.Empty; 
            definition = String.Empty;
            logic = LogicManagerFactory.CreateLogicManager(ILogicEnum.STANDARD);
            Next = new Command(Action, IsReady);
            logic.Current_Lexeme.PropertyChanged += Update!;
            logic.Init();
        }

        private void Action ()
        {
            logic.NextLexeme();
        }

        private bool IsReady()
        {
            return true;
        }

        public void Update(Object s, PropertyChangedEventArgs e)
        {
            Lexeme lexeme = (Lexeme)s;
            this.Word = lexeme.Word;
            this.Definition = lexeme.Definition;
        }

    }
}

