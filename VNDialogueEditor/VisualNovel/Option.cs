namespace VisualNovel {
    public class Option {
        public Redirect Redirect;
        public string Text;

        public Option(string text, Redirect redirect) {
            Text = text;
            Redirect = redirect;
        }
    }
}