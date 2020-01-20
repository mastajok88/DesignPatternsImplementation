using System;

namespace DoFluentBuilder
{
    public class Person
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public DateTime DateOfBirth;

        public class Builder : PersonBirthDateBuilder<Builder>
        {
            internal Builder()
            {
            }
        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(DateOfBirth)}: {DateOfBirth}, {nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}