using System;
using System.Collections.Generic;

namespace DoFunctionalBuilder
{
    public class PersonBuilder
    {
        public readonly List<Action<Person>> Actions = new List<Action<Person>>();

        public PersonBuilder Called(string name)
        {
            Actions.Add((p) => { p.Name = name; });
            return this;
        }

        public Person Build()
        {
            var person = new Person();
            Actions.ForEach(a => a(person));
            return person;
        }
    }
}