using FileRenamer.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLogic
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
