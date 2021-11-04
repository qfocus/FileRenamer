using System;
using System.Text.RegularExpressions;

namespace FileRenamer
{
    public class RegexRenamer : CharacterRenamer
    {
        public override string Delete(string name, string character)
        {
            return Rename(name, character, String.Empty);
        }

        public override string Rename(string name, string oldValue, string newValue)
        {
            Regex regex = new Regex(oldValue);

            return regex.Replace(name, newValue);

        }
    }
}
