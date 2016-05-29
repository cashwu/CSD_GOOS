using System.Collections.Generic;

namespace testGoos.Models
{
    public class HangmanViewModel
    {
        private readonly string _word;

        public HangmanViewModel(string word)
        {
            this._word = word;
        }

        public int Tries => 12;

        public int Length => _word.Length;

        public string Used => "aeiou";

        public string Discovered
        {
            get
            {
                var discovered = new List<char>();

                foreach (var c in _word)
                {
                    if ("aeiou".IndexOf(c.ToString()) != -1)
                    {
                        discovered.Add(c);
                    }
                    else
                    {
                        discovered.Add('_');
                    }
                }

                return string.Join("", discovered);
            }
        }
    }
}