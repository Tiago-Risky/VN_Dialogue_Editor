using System.Collections.Generic;

namespace VisualNovel {
    public class Chapter {
        public int Number;
        public string Background;
        private List<Dialogue> dialogues;
        public List<Dialogue> Dialogues {
            get { return dialogues ?? (dialogues = new List<Dialogue>()); }
        }

        public Chapter(int number, string background) {
            Number = number;
            Background = background;
        }
        public bool HasBackground() {
            return Background.Length > 0;
        }
    }
}