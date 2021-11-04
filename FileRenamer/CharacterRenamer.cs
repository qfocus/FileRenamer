using System;

namespace FileRenamer
{
    public abstract class CharacterRenamer : ICharacterRenamer
    {
        public virtual string Delete(string name, string character)
        {
            throw new NotImplementedException();
        }

        public virtual string Rename(string name, string oldValue, string newValue)
        {
            throw new NotImplementedException();
        }

        public string ToLower(string name)
        {
            return name.ToLower();
        }

        public string ToUpper(string name)
        {
            return name.ToUpper();
        }
    }
}
