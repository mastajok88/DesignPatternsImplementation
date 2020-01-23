namespace DoFactoryExample
{
    public interface IPersonFactory
    {
        (IPerson, int) Create(string name);
    }
}    