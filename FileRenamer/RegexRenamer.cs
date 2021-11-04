using System;
using System.Text.RegularExpressions;

namespace FileRenamer
{
    public class RegexRenamer : ICharacterRenamer
    {
        public string Delete(string name, string character)
        {
            return Rename(name, character, String.Empty);
        }

        public string Rename(string name, string oldValue, string newValue)
        {
            Regex regex = new Regex(oldValue);

            return regex.Replace(name, newValue);

        }
    }
}
