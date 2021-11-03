using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FileRenamer.Business
{
    public class GeneralRenamer : ICharacterRenamer
    {
        public string Delete(string name, string character)
        {
            return Rename(name, character, String.Empty);
        }

        public string Rename(string name, string oldValue, string newValue)
        {
            return name.Replace(oldValue, newValue);
        }
    }
}
