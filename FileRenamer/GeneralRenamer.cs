using System;

namespace FileRenamer
{
    public class GeneralRenamer : CharacterRenamer
    {
        public override string Delete(string name, string character)
        {
            return Rename(name, character, String.Empty);
        }

        public override string Rename(string name, string oldValue, string newValue)
        {
            return name.Replace(oldValue, newValue);
        }
    }
}
