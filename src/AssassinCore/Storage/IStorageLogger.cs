namespace AssassinCore.Storage
{
    public interface IStorageLogger // Scoped
    {
        void Write(string message);
    }
}