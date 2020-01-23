namespace DoFactoryExample
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Id)}: {Id}";
        }
    }
}