using System;

namespace DoFluentBuilder
{
    public class PersonBirthDateBuilder<TSelf> : PersonJobBuilder<PersonBirthDateBuilder<TSelf>>
        where TSelf : PersonBirthDateBuilder<TSelf>
    {
        public TSelf Born(DateTime dateOfBirth)
        {
            person.DateOfBirth = dateOfBirth;
            return (TSelf) this;
        }
    }
}