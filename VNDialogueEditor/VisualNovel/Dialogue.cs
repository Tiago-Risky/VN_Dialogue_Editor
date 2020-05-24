using System.Collections.Generic;
using System.Xml.Linq;

namespace VisualNovel {
    public class Dialogue {
        public int Number;
        public List<Character> Characters;
        public string Text;
        public Redirect Redirect;
        public List<Option> Options;
        public string Background;

        public Dialogue(int number, List<Character> characters, string text, Redirect redirect, List<Option> options, string background) {
            Number = number;
            Characters = characters;
            Text = text;
            Redirect = redirect;
            Options = options;
            Background = background;
        }

        public bool IsQuestion() {
            return Options != null;
        }

        public bool HasRedirect() {
            return Redirect != null;
        }

        public bool HasBackground() {
            return Background.Length > 0;
        }

        public bool HasCharacters() {
            return Characters.Count > 0;
        }

        public XElement ExportXML() {
            XElement xElement = new XElement("Dialogue", new XAttribute("Number", Number), new XElement("Text",Text));

            if (HasRedirect()) {
                xElement.Add(new XElement("Redirect",
                            new XAttribute("Chapter", Redirect.Chapter),
                            new XAttribute("Dialogue", Redirect.Dialogue))
                        );
            }

            if (HasBackground()) {
                xElement.Add(new XAttribute("Background", Background));
            }

            if (HasCharacters()) {
                XElement charactersElement = new XElement("Characters");
                foreach (Character character in Characters) {
                    charactersElement.Add(new XElement("Character",
                        new XAttribute("Name", character.Name),
                        new XAttribute("Picture", character.Picture),
                        new XAttribute("Side", character.Side),
                        new XAttribute("Selected", character.Selected),
                        new XAttribute("Hidden", character.Hidden)
                        )
                    );
                }
                xElement.Add(charactersElement);
            }

            if (IsQuestion()) {
                XElement optionsElement = new XElement("Options");
                foreach (Option option in Options) {
                    optionsElement.Add(new XElement("Option",
                        new XAttribute("Text", option.Text),
                        new XElement("Redirect",
                            new XAttribute("Chapter", option.Redirect.Chapter),
                            new XAttribute("Dialogue", option.Redirect.Dialogue))
                        )
                    );
                }
                xElement.Add(optionsElement);
            }

            return xElement;
        }
    }
}
