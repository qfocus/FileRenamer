using System;

namespace FileRenamer
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
