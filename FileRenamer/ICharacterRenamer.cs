namespace FileRenamer
{
    public interface ICharacterRenamer
    {
        string Rename(string name, string oldValue, string newValue);

        string Delete(string name, string character);
    }
}
