namespace DoFactoryExample
{
    public class PersonFactory : IPersonFactory
    {
        private int index = 0;

        public PersonFactory()
        {
            
        }
        
        public (IPerson, int) Create(string name)
        {
            var person = new Person()
            {
                Name = name,
                Id = index
            };
            index++;
            return (person, index);
        }
    }
}