using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer.Business
{
    public interface ICharacterRenamer
    {
        string Rename(string name, string oldValue, string newValue);

        string Delete(string name, string character);
    }
}
